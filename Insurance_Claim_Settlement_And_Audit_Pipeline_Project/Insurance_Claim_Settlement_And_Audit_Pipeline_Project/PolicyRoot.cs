using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline_Project
{
    public class PolicyRoot
    {
        public List<Policy> Policies { get; set; }= new List<Policy>();
    }
}
