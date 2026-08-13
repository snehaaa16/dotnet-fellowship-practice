using System;
using System.Collections.Generic;

namespace StackAndQueueAndHashMap
{
    internal class TwoSum
    {
        public static int[] FindTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map =
                new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int required = target - nums[i];

                if (map.ContainsKey(required))
                {
                    return new int[]
                    {
                        map[required],
                        i
                    };
                }

                map[nums[i]] = i;
            }

            return new int[] { -1, -1 };
        }

        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = FindTwoSum(nums, target);

            Console.WriteLine(
                $"[{result[0]}, {result[1]}]"
            );
        }
    }
}