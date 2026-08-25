using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Scenrio_Based_Review
{
    public class JobStack
    {
        public Stack<PrintJob> completed=new Stack<PrintJob>();
        public void Push(PrintJob job)
        {
            completed.Push(job);
        }

        public PrintJob Pop() {
            if (completed.Count == 0) return null;
            return completed.Pop();
        }

        public PrintJob Peek()
        {
            if (completed.Count == 0) return null;
            return completed.Peek();
        }
    }
}




































