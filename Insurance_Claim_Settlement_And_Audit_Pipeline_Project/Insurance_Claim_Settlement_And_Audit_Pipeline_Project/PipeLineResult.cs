using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Claim_Settlement_And_Audit_Pipeline_Project
{
    public class PipelineResult
    {
        public List<Settlement> Settlements { get; set; }= new List<Settlement>();

        public SummaryStatistics Summary { get; set; }= new SummaryStatistics();
    }
}
