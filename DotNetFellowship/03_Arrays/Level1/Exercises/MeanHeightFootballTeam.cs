using System;

namespace _03_Arrays.Level1.Exercises
{
    internal class MeanHeightFootballTeam
    {
        public static double CalculateMean(double[] heights)
        {
            double sum = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                sum += heights[i];
            }

            return sum / heights.Length;
        }
    }
}