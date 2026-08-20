namespace PerformanceComparison
{
    internal class SearchPerformance
    {
        public static int LinearSearch(int[] data, int target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                    return i;
            }

            return -1;
        }

        public static int BinarySearch(int[] data, int target)
        {
            int left = 0;
            int right = data.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (data[mid] == target)
                    return mid;

                if (data[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }
        public static void BubbleSort(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = 0; j < data.Length - i - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }
        public static void MergeSort(int[] data)
        {
            if (data.Length <= 1)
                return;

            int mid = data.Length / 2;

            int[] left = new int[mid];
            int[] right = new int[data.Length - mid];

            Array.Copy(data, 0, left, 0, mid);
            Array.Copy(data, mid, right, 0, data.Length - mid);

            MergeSort(left);
            MergeSort(right);

            Merge(data, left, right);
        }

        static void Merge(int[] data, int[] left, int[] right)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    data[k++] = left[i++];
                else
                    data[k++] = right[j++];
            }

            while (i < left.Length)
                data[k++] = left[i++];

            while (j < right.Length)
                data[k++] = right[j++];
        }

        public static void QuickSort(int[] data, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(data, low, high);

                QuickSort(data, low, pivotIndex - 1);
                QuickSort(data, pivotIndex + 1, high);
            }
        }

        static int Partition(int[] data, int low, int high)
        {
            int pivot = data[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (data[j] < pivot)
                {
                    i++;

                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                }
            }

            int temp2 = data[i + 1];
            data[i + 1] = data[high];
            data[high] = temp2;

            return i + 1;
        }
    }
}