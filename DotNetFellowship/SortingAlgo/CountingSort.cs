using System;

namespace SortingAlgo
{
    internal class CountingSort
    {
        public static void Sort(int[] arr)
        {
            int min = 10;
            int max = 18;

            // Count array
            int[] count = new int[max - min + 1];

            // Count frequency of each age
            foreach (int age in arr)
            {
                count[age - min]++;
            }

            // Put elements back in sorted order
            int index = 0;

            for (int i = 0; i < count.Length; i++)
            {
                while (count[i] > 0)
                {
                    arr[index] = i + min;
                    index++;

                    count[i]--;
                }
            }
        }
    }
}