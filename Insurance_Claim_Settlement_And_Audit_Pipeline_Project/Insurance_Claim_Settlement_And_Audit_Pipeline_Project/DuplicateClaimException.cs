using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline_Project
{
    public class DuplicateClaimException : ClaimException
    {
        public DuplicateClaimException(string claimId): base($"Claim '{claimId}' is a duplicate claim.")
        {
        }
    }
}
