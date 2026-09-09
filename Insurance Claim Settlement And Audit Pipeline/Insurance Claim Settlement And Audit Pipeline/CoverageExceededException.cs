using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline
{
    public class CoverageExceededException: Exception
    {
        public CoverageExceededException(decimal claimAmount,decimal coverageLimit): base($"Claim amount {claimAmount} exceeds coverage limit {coverageLimit}.")
        {
        }
    }
}
