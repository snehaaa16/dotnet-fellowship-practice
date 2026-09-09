using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline_Project
{
    public class InvalidClaimAmountException : ClaimException
    {
        public InvalidClaimAmountException(decimal amount): base($"Invalid claim amount '{amount}'. Claim amount must be greater than zero.")
        {
        }
    }
}
