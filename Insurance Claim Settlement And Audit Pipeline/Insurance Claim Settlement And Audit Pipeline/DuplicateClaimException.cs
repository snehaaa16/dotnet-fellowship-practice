using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline
{
    public class DuplicateClaimException:Exception
    {
        public DuplicateClaimException(string message) : base(message)
        {
            throw new("This PolicyHolder Already claim its money");
        }
    }
}
