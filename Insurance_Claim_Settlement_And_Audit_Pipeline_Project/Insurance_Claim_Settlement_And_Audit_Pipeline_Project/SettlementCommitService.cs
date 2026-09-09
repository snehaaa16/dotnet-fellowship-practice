using Insurance_Claim_Settlement_And_Audit_Pipeline_Project;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline_Project
{
    public class SettlementCommitService
    {
        public void Commit(string outputFile,List<Settlement> settlements)
        {
            SettlementRoot root = new SettlementRoot
            {
                Settlements = settlements
            };

            using FileStream fileStream =new FileStream(outputFile,FileMode.Create,FileAccess.Write,FileShare.Read);

            JsonSerializer.Serialize(fileStream,root,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });
        }
    }
}