using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Scenrio_Based_Review
{

    public class JobNode
    {
        public PrintJob Job;
        public JobNode Next;
        public JobNode Prev;

        public JobNode(PrintJob job)
        {
            Job = job;
        }
    }

}

















