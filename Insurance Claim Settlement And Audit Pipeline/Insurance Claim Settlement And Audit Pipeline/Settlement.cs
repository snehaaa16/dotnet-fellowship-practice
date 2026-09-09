using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline
{

    public class Settlement
    {
        public string ClaimId { get; set; } = "";
        public string PolicyId { get; set; } = "";
        public decimal ClaimAmount { get; set; }
        public decimal ApprovedAmount { get; set; }
        public string Decision { get; set; } = "";
    }
}
