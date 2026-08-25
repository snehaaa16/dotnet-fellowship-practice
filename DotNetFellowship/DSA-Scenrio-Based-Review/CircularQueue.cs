using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Scenrio_Based_Review
{
    public class CircularQueue
    {
        private Queue<int> printers = new Queue<int>();
        public CircularQueue(int count)
        {
            for(int i = 1; i <=count; i++)
            {
                printers.Enqueue(i);
            }
        }

        public int GetPrinter()
        {
            if (printers.Count == 0) return -1;

            int printer = printers.Dequeue();
            printers.Enqueue(printer);
            return printer;
        }
        public int Count()
        {
            return printers.Count;
        }
    }
}
