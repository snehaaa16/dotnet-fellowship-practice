using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline_Project
{
    public class CoverageExceededException : ClaimException
    {
        public CoverageExceededException(decimal claimAmount,decimal coverageLimit): base($"Claim amount {claimAmount} exceeds coverage limit {coverageLimit}.")
        {
        }
    }
}
