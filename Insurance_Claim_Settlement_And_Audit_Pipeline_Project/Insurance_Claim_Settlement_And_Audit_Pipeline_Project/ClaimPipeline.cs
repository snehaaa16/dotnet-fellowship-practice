using System;
using System.IO;
using System.Text.Json;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline_Project
{
    public class ClaimPipeline
    {
        public PolicyService policyService;
        public ClaimValidator validator;
        public ClaimProcessor processor;
        public AuditService auditService;
        public SettlementCommitService commitService;
        public ClaimPipeline(PolicyService policyService, ClaimValidator validator, ClaimProcessor processor, AuditService auditService, SettlementCommitService commitService)
        {
            this.policyService = policyService;
            this.validator = validator;
            this.processor = processor;
            this.auditService = auditService;
            this.commitService = commitService;
        }
        public PipelineResult Process(string claimsFile, string settlementFile, string auditLogFile)
        {
            PipelineResult result = new PipelineResult();
            SummaryStatistics summary = result.Summary;
            using FileStream fileStream = new FileStream(claimsFile, FileMode.Open, FileAccess.Read, FileShare.Read);
            using StreamReader reader = new StreamReader(fileStream);
            string? header = reader.ReadLine();
            if (header == null)
            {
                return result;
            }
            using FileStream auditFileStream = new FileStream(auditLogFile, FileMode.Create, FileAccess.Write, FileShare.Read);
            using BufferedStream bufferedStream = new BufferedStream(auditFileStream);
            using StreamWriter auditWriter = new StreamWriter(bufferedStream);
            int lineNumber = 1;
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                lineNumber++;
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                summary.TotalClaims++;
                Claim? claim = null;
                try
                {
                    claim = ClaimCsvParser.Parse(line, lineNumber);
                    validator.ValidateClaim(claim, policyService);
                    Policy policy = policyService.GetPolicy(claim.PolicyId);
                    Settlement settlement = processor.Process(claim, policy);
                    using MemoryStream stagingStream = new MemoryStream();
                    JsonSerializer.Serialize(stagingStream, settlement);
                    stagingStream.Position = 0;
                    Settlement? stagedSettlement = JsonSerializer.Deserialize<Settlement>(stagingStream);
                    if (stagedSettlement == null)
                    {
                        throw new InvalidDataException($"Settlement staging failed for claim '{claim.ClaimId}'.");
                    }
                    byte[] binaryAudit = auditService.CreateAuditToken(stagedSettlement);
                    AuditToken decodedToken = auditService.DecodeAuditToken(binaryAudit);
                    bool verified = auditService.Verify(stagedSettlement, decodedToken);
                    if (!verified)
                    {
                        throw new InvalidDataException($"Binary verification failed for claim '{claim.ClaimId}'.");
                    }
                    result.Settlements.Add(stagedSettlement);
                    summary.ApprovedClaims++;
                    summary.TotalClaimAmount += claim.ClaimAmount;
                    summary.TotalApprovedAmount += stagedSettlement.ApprovedAmount;
                    auditWriter.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | ClaimId={claim.ClaimId} | PolicyId={claim.PolicyId} | ClaimAmount={claim.ClaimAmount} | ApprovedAmount={stagedSettlement.ApprovedAmount} | Decision={stagedSettlement.Decision} | VERIFIED");
                }
                catch (ClaimException ex)
                {
                    summary.RejectedClaims++;
                    WriteRejectedAudit(auditWriter, claim, lineNumber, ex.Message);
                }
                catch (InvalidDataException ex)
                {
                    summary.RejectedClaims++;
                    WriteRejectedAudit(auditWriter, claim, lineNumber, ex.Message);
                }
                catch (Exception ex)
                {
                    summary.RejectedClaims++;
                    WriteRejectedAudit(auditWriter, claim, lineNumber, ex.Message);
                }
            }
            commitService.Commit(settlementFile, result.Settlements);
            auditWriter.WriteLine($"Total Claims={summary.TotalClaims}");
            auditWriter.WriteLine($"Approved Claims={summary.ApprovedClaims}");
            auditWriter.WriteLine($"Rejected Claims={summary.RejectedClaims}");
            auditWriter.WriteLine($"Total Claim Amount={summary.TotalClaimAmount}");
            auditWriter.WriteLine($"Total Approved Amount={summary.TotalApprovedAmount}");
            auditWriter.Flush();
            return result;
        }
        public static void WriteRejectedAudit(StreamWriter auditWriter, Claim? claim, int lineNumber, string error)
        {
            string claimId = claim?.ClaimId ?? "UNKNOWN";
            string policyId = claim?.PolicyId ?? "UNKNOWN";
            auditWriter.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | Line={lineNumber} | ClaimId={claimId} | PolicyId={policyId} | REJECTED | Reason={error}");
        }
    }
}