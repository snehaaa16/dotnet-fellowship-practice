using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline
{
    public class PolicyRoot
    {
        public List<Policy> policies { get; set; } = new List<Policy>();
    }
}
