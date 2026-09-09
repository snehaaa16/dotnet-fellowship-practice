using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline_Project
{
    public class PolicyNotFoundException : ClaimException
    {
        public PolicyNotFoundException(string policyId): base($"Policy '{policyId}' was not found.")
        {
        }
    }
}
