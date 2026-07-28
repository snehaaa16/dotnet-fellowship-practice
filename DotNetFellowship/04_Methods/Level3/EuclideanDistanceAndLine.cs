using System;

namespace _04_Methods.Level3
{
    public class EuclideanDistanceAndLine
    {
        // Find Euclidean Distance
        public static double FindDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        // Find Slope and Y-Intercept
        public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2)
            {
                return new double[0];
            }

            double slope = (y2 - y1) / (x2 - x1);
            double intercept = y1 - (slope * x1);

            return new double[] { slope, intercept };
        }
    }
}