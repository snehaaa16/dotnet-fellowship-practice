using System;

namespace _04_Methods.Level3
{
    public class FootballTeamStatistics
    {
        // Generate random heights
        public static int[] GenerateHeights(int size)
        {
            Random random = new Random();
            int[] heights = new int[size];

            for (int i = 0; i < size; i++)
            {
                heights[i] = random.Next(150, 251);
            }

            return heights;
        }

        // Find sum of heights
        public static int FindSum(int[] heights)
        {
            int sum = 0;

            foreach (int height in heights)
            {
                sum += height;
            }

            return sum;
        }

        // Find mean height
        public static double FindMeanHeight(int[] heights)
        {
            return (double)FindSum(heights) / heights.Length;
        }

        // Find shortest height
        public static int FindShortestHeight(int[] heights)
        {
            int shortest = heights[0];

            foreach (int height in heights)
            {
                if (height < shortest)
                {
                    shortest = height;
                }
            }

            return shortest;
        }

        // Find tallest height
        public static int FindTallestHeight(int[] heights)
        {
            int tallest = heights[0];

            foreach (int height in heights)
            {
                if (height > tallest)
                {
                    tallest = height;
                }
            }

            return tallest;
        }
    }
}