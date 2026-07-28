using System;

namespace _04_Methods.Level2
{
    public class FactorsOfNumber
    {
        public static int[] FindFactors(int number)
        {
            int count = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    count++;
            }

            int[] factors = new int[count];
            int index = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index] = i;
                    index++;
                }
            }

            return factors;
        }

        public static int FindSum(int[] factors)
        {
            int sum = 0;

            foreach (int factor in factors)
                sum += factor;

            return sum;
        }

        public static long FindProduct(int[] factors)
        {
            long product = 1;

            foreach (int factor in factors)
                product *= factor;

            return product;
        }

        public static double FindSumOfSquares(int[] factors)
        {
            double sum = 0;

            foreach (int factor in factors)
                sum += Math.Pow(factor, 2);

            return sum;
        }
    }
}