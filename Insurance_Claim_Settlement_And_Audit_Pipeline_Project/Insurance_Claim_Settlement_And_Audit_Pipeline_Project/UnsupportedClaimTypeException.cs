using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline_Project
{
    public class UnsupportedClaimTypeException : ClaimException
    {
        public UnsupportedClaimTypeException(string claimType): base($"Unsupported claim type '{claimType}'.")
        {
        }
    }
}
