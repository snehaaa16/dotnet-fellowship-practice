using System;
using System.Collections.Generic;
using System.Text;

namespace Reviews
{
    public class BinarySearch
    {
        public static int BinarySearchAlgorithm(int ele, int[] arr)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] == ele) return mid;
                else if (arr[mid] > ele) high = mid - 1;
                else low = mid + 1;
                
            }
            return low;

        }
        public static void Main()
        {
            int[] arr = new int[6];
            for(int i = 0; i < 6; i++)
            {
                arr[i] = (Convert.ToInt32(Console.ReadLine));
            }
            int idx = BinarySearchAlgorithm(10, arr);
            Console.WriteLine(idx);
        }
    }
}
