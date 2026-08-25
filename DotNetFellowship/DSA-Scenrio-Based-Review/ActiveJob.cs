using DSA_Scenrio_Based_Review;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Scenrio_Based_Review
{
    public class ActiveJob
    {
        public JobNode head;
        public JobNode tail;

        public void Add( PrintJob job)
        {
            JobNode node = new JobNode(job);
            if(head == null)
            {
                head=tail=node;
                return;
            }
            tail.Next = node;
            node.Prev = tail;
            tail = node;
        }
        public bool Remove(string jobId)
        {
            JobNode current = head;
            while (current != null)
            {
            if (current.Job.JobId == jobId)
            {
                if (current.Prev != null) current.Prev.Next = current.Next;
                else head = current.Next;

                if (current.Next != null) current.Next.Prev = current.Prev;
                else tail = current.Prev;
                return true;
            }
            current = current.Next;
            }
            return false;
        }

        public bool RePriotize( string jobId, int priority)
        {
            JobNode current = head;
            while (current.Next != null)
            {
                if (current.Job.JobId == jobId) {
                    current.Job.Priority = priority;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void DisplayForward()
        {
            JobNode current = head;
            while (current != null)
            {
                Console.WriteLine($"JobId-: " + current.Job.JobId+" with priority-: " + current.Job.Priority);
                current = current.Next;
            }
        }

        public void DisplayBackward()
        {
            JobNode current = tail;

            while (current != null)
            {
                Console.WriteLine($"JobId-: " + current.Job.JobId + " with priority-: " + current.Job.Priority);
                current = current.Prev;
            }
        }
    }
}


















