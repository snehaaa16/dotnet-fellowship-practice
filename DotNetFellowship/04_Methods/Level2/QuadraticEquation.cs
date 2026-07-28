using System;

namespace _04_Methods.Level2
{
    public class QuadraticEquation
    {
        public static double[] FindRoots(double a, double b, double c)
        {
            double delta = (b * b) - (4 * a * c);

            if (delta > 0)
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);

                return new double[] { root1, root2 };
            }
            else if (delta == 0)
            {
                double root = -b / (2 * a);

                return new double[] { root };
            }

            return new double[0];
        }
    }
}