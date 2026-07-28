using System;

namespace _04_Methods.Level1
{
    public class TriangularParkRounds
    {
        public static double CalculateRounds(double side1, double side2, double side3)
        {
            double perimeter = side1 + side2 + side3;
            double rounds = 5000 / perimeter;

            return rounds;
        }
    }
}