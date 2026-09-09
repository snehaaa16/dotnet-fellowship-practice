using System;
using System.IO;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline_Project
{
    public class Program
    {
        static void Main()
        {
            string projectPath = Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.Parent!.FullName;
            string claimsFile = Path.Combine(projectPath, "claims.csv");
            string policiesFile = Path.Combine(projectPath, "policies.json");
            string settlementFile = Path.Combine(projectPath, "claim_settlements.json");
            string auditFile = Path.Combine(projectPath, "claim_audit.log");
            try
            {
                PolicyService policyService = new PolicyService(policiesFile);
                ClaimValidator validator = new ClaimValidator();
                ClaimProcessor processor = new ClaimProcessor();
                AuditService auditService = new AuditService();
                SettlementCommitService commitService = new SettlementCommitService();
                ClaimPipeline pipeline = new ClaimPipeline(policyService, validator, processor, auditService, commitService);
                PipelineResult result = pipeline.Process(claimsFile, settlementFile, auditFile);
                Console.WriteLine("Pipeline completed.");
                Console.WriteLine();
                Console.WriteLine(result.Summary);
                Console.WriteLine();
                Console.WriteLine("Settlement file: " + settlementFile);
                Console.WriteLine("Audit file: " + auditFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Pipeline failed: " + ex.Message);
            }
        }
    }
}