using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline
{
    public class ClaimValidator
    {
        public HashSet<string> processedClaimIds = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        public static readonly HashSet<string> SupportedClaimTypes = new HashSet<string>(new[] { "HEALTH,VEHICLE" }, StringComparer.OrdinalIgnoreCase);

        public void ValidateClaim(Claim claim, PolicyService policyService)
        {
            if (string.IsNullOrWhiteSpace(claim.ClaimId))
            {
                throw new ClaimException("ClaimId cannot be empty");
            }

            if (!processedClaimIds.Add(claim.ClaimId))
            {
                throw new DuplicateClaimException(claim.ClaimId);
            }

            if (string.IsNullOrWhiteSpace(claim.ClaimType))
            {
                throw new ClaimException($"Claim '{claim.ClaimId}': ClaimType cannot be empty.");
            }

            if (!SupportedClaimTypes.Contains(claim.ClaimType))
            {
                throw new UnsupportedClaimTypeException(claim.ClaimType);
            }
            if (claim.ClaimAmount <= 0)
            {
                throw new InvalidClaimAmountException(claim.ClaimAmount);
            }
            if (claim.SubmittedDate == default)
            {
                throw new ClaimException($"Claim '{claim.ClaimId}': Invalid submitted date.");
            }
            Policy policy = policyService.GetPolicy(claim.PolicyId);
            if (!policy.Coverage.TryGetValue(claim.ClaimType, out decimal coverageLimit))
            {
                throw new UnsupportedClaimTypeException(claim.ClaimType);
            }

            if (claim.ClaimAmount > coverageLimit)
            {
                throw new CoverageExceededException(claim.ClaimAmount, coverageLimit);
            }
        }

            public void MarkClaimAsProcessed(string claimId)
            {
                processedClaimIds.Add(claimId);
            }
    }
}
