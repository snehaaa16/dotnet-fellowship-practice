using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgo
{
    internal class InsertionSort
    {
        public static void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                // Larger elements ko right shift karo
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                // Key ko correct position par insert karo
                arr[j + 1] = key;
            }
        }
    }
}