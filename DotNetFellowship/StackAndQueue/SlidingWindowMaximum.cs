using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueAndHashMap
{
    internal class SlidingWindowMaximum
    {
        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums.Length == 0 || k == 0)
                return new int[0];

            int[] result = new int[nums.Length - k + 1];

            LinkedList<int> deque = new LinkedList<int>();

            int resultIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                // Remove indices outside current window
                if (deque.Count > 0 &&
                    deque.First.Value <= i - k)
                {
                    deque.RemoveFirst();
                }

                // Remove smaller elements from back
                while (deque.Count > 0 &&
                       nums[deque.Last.Value] <= nums[i])
                {
                    deque.RemoveLast();
                }

                deque.AddLast(i);

                // Window is ready
                if (i >= k - 1)
                {
                    result[resultIndex] = nums[deque.First.Value];
                    resultIndex++;
                }
            }

            return result;
        }

        static void Main()
        {
            int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;

            int[] result = MaxSlidingWindow(nums, k);

            Console.WriteLine("Sliding Window Maximum:");

            foreach (int value in result)
            {
                Console.Write(value + " ");
            }
        }
    }
}
