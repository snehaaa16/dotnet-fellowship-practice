using System;

namespace SortingAlgo
{
    internal class MergeSort
    {
        public static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                // Left half
                Sort(arr, left, mid);

                // Right half
                Sort(arr, mid + 1, right);

                // Merge both halves
                Merge(arr, left, mid, right);
            }
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1];

            int i = left;
            int j = mid + 1;
            int k = 0;

            // Compare elements from both halves
            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k] = arr[i];
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                }

                k++;
            }

            // Remaining elements of left half
            while (i <= mid)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }

            // Remaining elements of right half
            while (j <= right)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }

            // Copy temp back to original array
            for (int x = 0; x < temp.Length; x++)
            {
                arr[left + x] = temp[x];
            }
        }
    }
}