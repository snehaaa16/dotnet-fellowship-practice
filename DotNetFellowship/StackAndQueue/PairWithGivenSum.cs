using System;
using System.Collections.Generic;

namespace StackAndQueueAndHashMap
{
    internal class PairWithGivenSum
    {
        public static bool HasPair(int[] arr, int target)
        {
            HashSet<int> seen = new HashSet<int>();

            foreach (int num in arr)
            {
                int required = target - num;

                if (seen.Contains(required))
                {
                    Console.WriteLine(
                        $"Pair found: {required} + {num} = {target}"
                    );

                    return true;
                }

                seen.Add(num);
            }

            return false;
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 8, 4, 7, 11 };
            int target = 9;

            bool result = HasPair(arr, target);

            Console.WriteLine("Result: " + result);
        }
    }
}