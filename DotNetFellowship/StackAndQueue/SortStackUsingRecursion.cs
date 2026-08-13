using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueAndHashMap
{
    internal class SortStackUsingRecursion
    {
        static void SortStack(Stack<int> stack)
        {
            if (stack.Count == 0)
                return;

            int value = stack.Pop();

            SortStack(stack);

            InsertSorted(stack, value);
        }

        static void InsertSorted(Stack<int> stack, int value)
        {
            if (stack.Count == 0 || stack.Peek() <= value)
            {
                stack.Push(value);
                return;
            }

            int top = stack.Pop();

            InsertSorted(stack, value);

            stack.Push(top);
        }

        static void Main()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(3);
            stack.Push(1);
            stack.Push(4);
            stack.Push(2);

            SortStack(stack);

            Console.WriteLine("Sorted Stack:");

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
