using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Scenrio_Based_Review
{
    public class PrintJob
    {
        public string JobId { get; set; }
        public string Document { get; set; }
        public int Priority { get; set; }
        public int Size { get; set; }

        public DateTime Timestamp { get; set; }
        public PrintJob(string JobId,string Document,int Priority,int Size)
        {
            this.JobId = JobId;
            this.Document = Document;
            this.Priority = Priority;
            this.Size = Size;
            Timestamp = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{JobId} | {Document} | Priority: {Priority} | Size: {Size}";
        }
    }
}

















