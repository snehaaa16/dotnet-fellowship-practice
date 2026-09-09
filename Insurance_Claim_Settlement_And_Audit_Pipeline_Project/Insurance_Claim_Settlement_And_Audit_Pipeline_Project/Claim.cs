using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline_Project
{
    public class Claim
    {
        public string ClaimId { get; set; } = "";
        public string PolicyId { get; set; } = "";
        public decimal ClaimAmount { get; set; }
        public string ClaimType { get; set; } = "";
        public DateTime SubmittedDate { get; set; }
    }
}
