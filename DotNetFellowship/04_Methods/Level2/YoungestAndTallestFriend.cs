using System;

namespace _04_Methods.Level2
{
    public class YoungestAndTallestFriend
    {
        public static int FindYoungest(int[] ages)
        {
            int youngest = ages[0];

            for (int i = 1; i < ages.Length; i++)
            {
                if (ages[i] < youngest)
                    youngest = ages[i];
            }

            return youngest;
        }

        public static int FindTallest(int[] heights)
        {
            int tallest = heights[0];

            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > tallest)
                    tallest = heights[i];
            }

            return tallest;
        }
    }
}