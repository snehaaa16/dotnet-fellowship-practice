using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline
{

    public class ClaimProcessor
    {
        public Settlement Process(Claim claim, Policy policy)
        {
            decimal deductible = 0;

            if (policy.Deductible.TryGetValue(claim.ClaimType,out decimal configuredDeductible))
            {
                deductible = configuredDeductible;
            }

            decimal approvedAmount =claim.ClaimAmount - deductible;

            if (approvedAmount < 0)
            {
                approvedAmount = 0;
            }

            return new Settlement
            {
                ClaimId = claim.ClaimId,
                PolicyId = claim.PolicyId,
                ClaimAmount = claim.ClaimAmount,
                ApprovedAmount = approvedAmount,
                Decision = "APPROVED"
            };
        }
    }
}
