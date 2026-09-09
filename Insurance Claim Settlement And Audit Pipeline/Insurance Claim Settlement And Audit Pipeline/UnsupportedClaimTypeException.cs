using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline
{
    public class UnsupportedClaimTypeException:Exception
    {
        public UnsupportedClaimTypeException(string claimType): base($"Unsupported claim type '{claimType}'.")
        {
        }
    }
}
