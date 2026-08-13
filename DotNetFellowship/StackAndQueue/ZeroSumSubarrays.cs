using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueAndHashMap
{
    internal class ZeroSumSubarrays
    {
        public static void FindZeroSumSubarrays(int[] arr)
        {
            Dictionary<int, List<int>> map =
                new Dictionary<int, List<int>>();

            int prefixSum = 0;

            // Sum 0 initially index -1 par maana
            map[0] = new List<int>();
            map[0].Add(-1);

            for (int i = 0; i < arr.Length; i++)
            {
                prefixSum += arr[i];

                if (map.ContainsKey(prefixSum))
                {
                    foreach (int startIndex in map[prefixSum])
                    {
                        Console.Write("[ ");

                        for (int j = startIndex + 1; j <= i; j++)
                        {
                            Console.Write(arr[j] + " ");
                        }

                        Console.WriteLine("]");
                    }

                    map[prefixSum].Add(i);
                }
                else
                {
                    map[prefixSum] = new List<int>();
                    map[prefixSum].Add(i);
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 3, 4, -7, 3, 1, 3, 1, -4 };

            Console.WriteLine("Zero Sum Subarrays:");

            FindZeroSumSubarrays(arr);
        }
    }
}