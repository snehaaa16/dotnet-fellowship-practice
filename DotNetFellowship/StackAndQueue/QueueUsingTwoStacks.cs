using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueAndHashMap
{
    internal class QueueUsingTwoStacks
    {
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();

        public void Enqueue(int value)
        {
            stack1.Push(value);
        }

        public int Dequeue()
        {
            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            if (stack2.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return stack2.Pop();
        }

        public int Peek()
        {
            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            if (stack2.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return stack2.Peek();
        }

        public bool IsEmpty()
        {
            return stack1.Count == 0 && stack2.Count == 0;
        }

        static void Main()
        {
            QueueUsingTwoStacks queue = new QueueUsingTwoStacks();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            queue.Enqueue(40);

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Console.WriteLine(queue.IsEmpty());
        }
    }
}
