using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline
{
    public class SettlementRoot
    {
        public List<Settlement> Settlements { get; set; }= new List<Settlement>();
    }
}
