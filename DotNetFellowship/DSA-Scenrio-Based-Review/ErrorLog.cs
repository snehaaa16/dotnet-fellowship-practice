using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Scenrio_Based_Review
{
    public class ErrorLog
    {
        public ErrorNode head;
        public ErrorNode tail;

        public void Add(string error)
        {
            ErrorNode node = new ErrorNode(error);
            if (head == null)
            {
                head = tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }
        public void Display()
        {
            ErrorNode current = head;

            while (current != null)
            {
                Console.WriteLine(current.Errors);
                current = current.Next;
            }
        }
    }
}
