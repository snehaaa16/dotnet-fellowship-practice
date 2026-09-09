using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline
{
    public class Policy
    {
        public string Id { get; set; } = "";
        public Dictionary<string, decimal> Coverage { get; set; }= new Dictionary<string, decimal>();

        public Dictionary<string, decimal> Deductible { get; set; }= new Dictionary<string, decimal>();
    }


}
