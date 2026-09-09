using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline
{
    public class PolicyNotFoundException : Exception
    {
        public PolicyNotFoundException(string policyId): base($"Policy '{policyId}' was not found.")
        {
        }
    }
}
