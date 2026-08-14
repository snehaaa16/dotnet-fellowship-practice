using System;

namespace SortingAlgo
{
    internal class HeapSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            // Build Max Heap
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            // Move largest element to the end
            for (int i = n - 1; i > 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // Heapify remaining elements
                Heapify(arr, i, 0);
            }
        }

        private static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;

            int left = 2 * i + 1;
            int right = 2 * i + 2;

            // Check left child
            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }

            // Check right child
            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

            // If largest is not the parent
            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                Heapify(arr, n, largest);
            }
        }
    }
}