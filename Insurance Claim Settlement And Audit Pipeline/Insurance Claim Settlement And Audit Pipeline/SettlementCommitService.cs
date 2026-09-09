using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline
{
    public class SettlementCommitService
    {
        public void Commit(string outputFile, List<Settlement> settlements)
        {
            SettlementRoot root = new SettlementRoot
            {
                Settlements = settlements
            };

            using FileStream fileStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.Read);
            JsonSerializer.Serialize(fileStream, root,new JsonSerializerOptions
            {
                 WriteIndented = true
            });
        }
    }
}
