using NUnit.Framework;
using System;
using System.IO;
using InsuranceClaim;
using Insurance_Claim_Settlement_And_Audit_Pipeline_Project;

namespace InsuranceClaim.Tests
{
    public class Tests
    {
        private string testFolder = "";
        private string claimsFile = "";
        private string policiesFile = "";
        private string settlementFile = "";
        private string auditFile = "";

        [SetUp]
        public void Setup()
        {
            testFolder = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(testFolder);
            claimsFile = Path.Combine(testFolder, "claims.csv");
            policiesFile = Path.Combine(testFolder, "policies.json");
            settlementFile = Path.Combine(testFolder, "claim_settlements.json");
            auditFile = Path.Combine(testFolder, "claim_audit.log");

            File.WriteAllText(policiesFile, "{\"policies\":[{\"id\":\"POL1\",\"coverage\":{\"HEALTH\":200000},\"deductible\":{\"HEALTH\":1000}},{\"id\":\"POL2\",\"coverage\":{\"VEHICLE\":100000},\"deductible\":{\"VEHICLE\":2000}}]}");
        }

        [TearDown]
        public void Cleanup()
        {
            if (Directory.Exists(testFolder))
            {
                Directory.Delete(testFolder, true);
            }
        }

        private ClaimPipeline CreatePipeline()
        {
            PolicyService policyService = new PolicyService(policiesFile);
            ClaimValidator validator = new ClaimValidator();
            ClaimProcessor processor = new ClaimProcessor();
            AuditService auditService = new AuditService();
            SettlementCommitService commitService = new SettlementCommitService();
            return new ClaimPipeline(policyService, validator, processor, auditService, commitService);
        }

        private void WriteClaims(params string[] claims)
        {
            string content = "ClaimId,PolicyId,ClaimAmount,ClaimType,SubmittedDate\n" + string.Join("\n", claims);
            File.WriteAllText(claimsFile, content);
        }

        [Test]
        public void ValidHealthClaim_ShouldBeApproved()
        {
            WriteClaims("CL1,POL1,15000,HEALTH,2026-09-01");
            PipelineResult result = CreatePipeline().Process(claimsFile, settlementFile, auditFile);
            Assert.That(result.Summary.ApprovedClaims, Is.EqualTo(1));
            Assert.That(result.Summary.RejectedClaims, Is.EqualTo(0));
            Assert.That(result.Settlements[0].ApprovedAmount, Is.EqualTo(14000));
        }

        [Test]
        public void ValidVehicleClaim_ShouldBeApproved()
        {
            WriteClaims("CL2,POL2,80000,VEHICLE,2026-09-02");
            PipelineResult result = CreatePipeline().Process(claimsFile, settlementFile, auditFile);
            Assert.That(result.Summary.ApprovedClaims, Is.EqualTo(1));
            Assert.That(result.Settlements[0].ApprovedAmount, Is.EqualTo(78000));
        }

        [Test]
        public void ClaimExceedingCoverage_ShouldBeRejected()
        {
            WriteClaims("CL4,POL1,500000,HEALTH,2026-09-03");
            PipelineResult result = CreatePipeline().Process(claimsFile, settlementFile, auditFile);
            Assert.That(result.Summary.RejectedClaims, Is.EqualTo(1));
            Assert.That(result.Settlements, Is.Empty);
        }

        [Test]
        public void UnknownPolicy_ShouldBeRejected()
        {
            WriteClaims("CL3,POL9,5000,HEALTH,2026-09-02");
            PipelineResult result = CreatePipeline().Process(claimsFile, settlementFile, auditFile);
            Assert.That(result.Summary.RejectedClaims, Is.EqualTo(1));
            Assert.That(File.ReadAllText(auditFile), Does.Contain("Policy 'POL9' was not found."));
        }

        [Test]
        public void UnsupportedClaimType_ShouldBeRejected()
        {
            WriteClaims("CL5,POL1,5000,LIFE,2026-09-02");
            PipelineResult result = CreatePipeline().Process(claimsFile, settlementFile, auditFile);
            Assert.That(result.Summary.RejectedClaims, Is.EqualTo(1));
            Assert.That(result.Settlements, Is.Empty);
        }

        [Test]
        public void DuplicateClaimId_ShouldBeRejected()
        {
            WriteClaims("CL1,POL1,15000,HEALTH,2026-09-01", "CL1,POL1,15000,HEALTH,2026-09-01");
            PipelineResult result = CreatePipeline().Process(claimsFile, settlementFile, auditFile);
            Assert.That(result.Summary.ApprovedClaims, Is.EqualTo(1));
            Assert.That(result.Summary.RejectedClaims, Is.EqualTo(1));
        }

        [Test]
        public void NegativeClaimAmount_ShouldBeRejected()
        {
            WriteClaims("CL6,POL1,-5000,HEALTH,2026-09-01");
            PipelineResult result = CreatePipeline().Process(claimsFile, settlementFile, auditFile);
            Assert.That(result.Summary.RejectedClaims, Is.EqualTo(1));
            Assert.That(result.Settlements, Is.Empty);
        }

        [Test]
        public void ZeroClaimAmount_ShouldBeRejected()
        {
            WriteClaims("CL7,POL1,0,HEALTH,2026-09-01");
            PipelineResult result = CreatePipeline().Process(claimsFile, settlementFile, auditFile);
            Assert.That(result.Summary.RejectedClaims, Is.EqualTo(1));
            Assert.That(result.Settlements, Is.Empty);
        }

        [Test]
        public void InvalidSubmittedDate_ShouldBeRejected()
        {
            WriteClaims("CL8,POL1,5000,HEALTH,2026-99-99");
            PipelineResult result = CreatePipeline().Process(claimsFile, settlementFile, auditFile);
            Assert.That(result.Summary.RejectedClaims, Is.EqualTo(1));
            Assert.That(result.Settlements, Is.Empty);
        }

        [Test]
        public void BinaryAuditEncodeDecode_ShouldMatch()
        {
            Settlement settlement = new Settlement
            {
                ClaimId = "CL1",
                PolicyId = "POL1",
                ClaimAmount = 15000,
                ApprovedAmount = 14000,
                Decision = "APPROVED"
            };

            AuditService auditService = new AuditService();
            byte[] data = auditService.CreateAuditToken(settlement);
            AuditToken token = auditService.DecodeAuditToken(data);

            Assert.That(auditService.Verify(settlement, token), Is.True);
        }

        [Test]
        public void CorruptedBinaryData_ShouldThrowException()
        {
            Settlement settlement = new Settlement
            {
                ClaimId = "CL1",
                PolicyId = "POL1",
                ClaimAmount = 15000,
                ApprovedAmount = 14000,
                Decision = "APPROVED"
            };

            AuditService auditService = new AuditService();
            byte[] data = auditService.CreateAuditToken(settlement);
            Array.Resize(ref data, data.Length - 2);

            Assert.Throws<InvalidDataException>(() => auditService.DecodeAuditToken(data));
        }

        [Test]
        public void EmptyCsv_ShouldReturnEmptyResult()
        {
            File.WriteAllText(claimsFile, "");
            PipelineResult result = CreatePipeline().Process(claimsFile, settlementFile, auditFile);
            Assert.That(result.Settlements, Is.Empty);
            Assert.That(result.Summary.TotalClaims, Is.EqualTo(0));
        }

        [Test]
        public void InvalidClaim_ShouldNotStopValidClaims()
        {
            WriteClaims("CL1,POL1,15000,HEALTH,2026-09-01", "CL3,POL9,5000,HEALTH,2026-09-02", "CL2,POL2,80000,VEHICLE,2026-09-02");
            PipelineResult result = CreatePipeline().Process(claimsFile, settlementFile, auditFile);
            Assert.That(result.Summary.TotalClaims, Is.EqualTo(3));
            Assert.That(result.Summary.ApprovedClaims, Is.EqualTo(2));
            Assert.That(result.Summary.RejectedClaims, Is.EqualTo(1));
            Assert.That(result.Settlements.Count, Is.EqualTo(2));
        }

        [Test]
        public void ApprovedAmount_ShouldSubtractDeductible()
        {
            WriteClaims("CL1,POL1,15000,HEALTH,2026-09-01");
            PipelineResult result = CreatePipeline().Process(claimsFile, settlementFile, auditFile);
            Assert.That(result.Settlements[0].ApprovedAmount, Is.EqualTo(14000));
        }

        [Test]
        public void SummaryStatistics_ShouldBeCalculatedCorrectly()
        {
            WriteClaims("CL1,POL1,15000,HEALTH,2026-09-01", "CL2,POL2,80000,VEHICLE,2026-09-02", "CL3,POL9,5000,HEALTH,2026-09-02", "CL4,POL1,500000,HEALTH,2026-09-03", "CL1,POL1,15000,HEALTH,2026-09-01");
            PipelineResult result = CreatePipeline().Process(claimsFile, settlementFile, auditFile);
            Assert.That(result.Summary.TotalClaims, Is.EqualTo(5));
            Assert.That(result.Summary.ApprovedClaims, Is.EqualTo(2));
            Assert.That(result.Summary.RejectedClaims, Is.EqualTo(3));
            Assert.That(result.Summary.TotalClaimAmount, Is.EqualTo(95000));
            Assert.That(result.Summary.TotalApprovedAmount, Is.EqualTo(92000));
        }

        [Test]
        public void CompletePipeline_ShouldCreateSettlementAndAuditFiles()
        {
            WriteClaims("CL1,POL1,15000,HEALTH,2026-09-01");
            PipelineResult result = CreatePipeline().Process(claimsFile, settlementFile, auditFile);
            Assert.That(result.Summary.ApprovedClaims, Is.EqualTo(1));
            Assert.That(File.Exists(settlementFile), Is.True);
            Assert.That(File.Exists(auditFile), Is.True);
            Assert.That(File.ReadAllText(settlementFile), Does.Contain("CL1"));
            Assert.That(File.ReadAllText(settlementFile), Does.Contain("14000"));
            Assert.That(File.ReadAllText(auditFile), Does.Contain("VERIFIED"));
        }
    }
}