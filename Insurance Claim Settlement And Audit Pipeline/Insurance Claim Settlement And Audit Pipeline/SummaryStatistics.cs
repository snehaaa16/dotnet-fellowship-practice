using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline
{
    public class SummaryStatistics
    {
        public int TotalClaims { get; set; }
        public int ApprovedClaims { get; set; }
        public int RejectedClaims { get; set; }

        public decimal TotalClaimAmount { get; set; }
        public decimal TotalApprovedAmount { get; set; }

        public override string ToString()
        {
            return $"TotalClaims:{TotalClaims} " +
                $" ApprovedClaims:{ApprovedClaims} " +
                $" RejectedClaims:{RejectedClaims}" +
                $" TotalClaimAmount:{TotalClaimAmount} " +
                $"TotalApprovedAmount :{TotalApprovedAmount}";
        }
    }
}
