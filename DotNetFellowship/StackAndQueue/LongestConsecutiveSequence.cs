using System;
using System.Collections.Generic;

namespace StackAndQueueAndHashMap
{
    internal class LongestConsecutiveSequence
    {
        public static int FindLongest(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();

            // Saare elements HashSet mein store karo
            foreach (int num in arr)
            {
                set.Add(num);
            }

            int longest = 0;

            foreach (int num in set)
            {
                // Agar num-1 nahi hai,
                // toh num sequence ka starting point hai
                if (!set.Contains(num - 1))
                {
                    int current = num;
                    int length = 1;

                    // Consecutive numbers check karo
                    while (set.Contains(current + 1))
                    {
                        current++;
                        length++;
                    }

                    longest = Math.Max(longest, length);
                }
            }

            return longest;
        }

        static void Main(string[] args)
        {
            int[] arr = { 100, 4, 200, 1, 3, 2 };

            int result = FindLongest(arr);

            Console.WriteLine(
                "Longest Consecutive Sequence Length: " + result
            );
        }
    }
}