using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline
{
    public class ClaimPipeline
    {
        public PolicyService policyService;
        public ClaimValidator validator;
        public ClaimProcessor processor;
        public AuditService auditService;

        public ClaimPipeline(PolicyService policyService,ClaimValidator validator,ClaimProcessor processor,AuditService auditService)
        {
            policyService = policyService;
            validator = validator;
            processor = processor;
            auditService = auditService;
        }

        public PipelineResult Process(string claimsFile,string auditLogFile)
        {
            PipelineResult result = new PipelineResult();

            SummaryStatistics summary =result.Summary;

            using FileStream fileStream =
                new FileStream( claimsFile,
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.Read);

            using StreamReader reader =new StreamReader(fileStream);
            string? header = reader.ReadLine();
            if (header == null)
            {
                return result;
            }

            int lineNumber = 1;

            using FileStream auditFileStream =new FileStream(auditLogFile,FileMode.Create,FileAccess.Write,FileShare.Read);

            using BufferedStream bufferedStream = new BufferedStream(auditFileStream);

            using StreamWriter auditWriter = new StreamWriter(bufferedStream);

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

                    claim = ClaimCsvParser.Parse(line,lineNumber);

                    validator.ValidateClaim(claim,policyService);

                    Policy policy =policyService.GetPolicy(claim.PolicyId);

                    Settlement settlement =processor.Process(claim,policy);

                    using MemoryStream stagingStream =new MemoryStream();
                    JsonSerializer.Serialize(stagingStream,settlement);

                    stagingStream.Position = 0;

                    byte[] binaryAudit = auditService.CreateAuditToken(settlement);

                    AuditToken decodedToken =auditService.DecodeAuditToken(binaryAudit);

                    bool verified =auditService.Verify(settlement,decodedToken);

                    if (!verified)
                    {
                        throw new InvalidDataException($"Binary verification failed for claim '{claim.ClaimId}'.");
                    }

                    result.Settlements.Add(settlement);

                    summary.ApprovedClaims++;

                    summary.TotalClaimAmount +=claim.ClaimAmount;

                    summary.TotalApprovedAmount +=settlement.ApprovedAmount;

                    auditWriter.WriteLine(
                        $"{DateTime.Now:yyyy-MM-dd} | " +
                        $"ClaimId={claim.ClaimId} | " +
                        $"PolicyId={claim.PolicyId} | " +
                        $"ClaimAmount={claim.ClaimAmount} | " +
                        $"ApprovedAmount={settlement.ApprovedAmount} | " +
                        $"Decision={settlement.Decision} | " +
                        $"VERIFIED");
                }
                catch (ClaimException ex)
                {
                    summary.RejectedClaims++;

                    WriteRejectedAudit(auditWriter,claim,lineNumber,ex.Message);
                }
                catch (FormatException ex)
                {
                    summary.RejectedClaims++;

                    WriteRejectedAudit(auditWriter,claim,lineNumber,ex.Message);
                }
                catch (InvalidDataException ex)
                {
                    summary.RejectedClaims++;

                    WriteRejectedAudit(auditWriter,claim,lineNumber,ex.Message);
                }
            }
            auditWriter.WriteLine($"Total Claims={summary.TotalClaims}");
            auditWriter.WriteLine($"Approved Claims={summary.ApprovedClaims}");
            auditWriter.WriteLine($"Rejected Claims={summary.RejectedClaims}");
            auditWriter.WriteLine($"Total Claim Amount={summary.TotalClaimAmount}");
            auditWriter.WriteLine($"Total Approved Amount={summary.TotalApprovedAmount}");
            auditWriter.Flush();

            return result;
        }

        private static void WriteRejectedAudit(StreamWriter auditWriter,Claim? claim,int lineNumber,string error)
        {
            string claimId =claim?.ClaimId ?? "UNKNOWN";

            string policyId =claim?.PolicyId ?? "UNKNOWN";

            auditWriter.WriteLine(
                $"{DateTime.Now:yyyy-MM-dd} | " +
                $"Line={lineNumber} | " +
                $"ClaimId={claimId} | " +
                $"PolicyId={policyId} | " +
                $"REJECTED | " +
                $"Reason={error}");
        }
    }
}
