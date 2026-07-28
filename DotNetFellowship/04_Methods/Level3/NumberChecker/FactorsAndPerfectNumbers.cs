using System;

namespace _04_Methods.Level3.NumberChecker
{
    public class FactorsAndPerfectNumbers
    {
        // Find Factors
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

        // Greatest Factor
        public static int FindGreatestFactor(int[] factors)
        {
            return factors[factors.Length - 1];
        }

        // Sum of Factors
        public static int FindSumOfFactors(int[] factors)
        {
            int sum = 0;

            foreach (int factor in factors)
            {
                sum += factor;
            }

            return sum;
        }

        // Product of Factors
        public static long FindProductOfFactors(int[] factors)
        {
            long product = 1;

            foreach (int factor in factors)
            {
                product *= factor;
            }

            return product;
        }

        // Product of Cube of Factors
        public static double FindProductOfCubeOfFactors(int[] factors)
        {
            double product = 1;

            foreach (int factor in factors)
            {
                product *= Math.Pow(factor, 3);
            }

            return product;
        }

        // Perfect Number
        public static bool IsPerfectNumber(int number)
        {
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum += i;
            }

            return sum == number;
        }

        // Abundant Number
        public static bool IsAbundantNumber(int number)
        {
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum += i;
            }

            return sum > number;
        }

        // Deficient Number
        public static bool IsDeficientNumber(int number)
        {
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum += i;
            }

            return sum < number;
        }

        // Factorial
        public static int Factorial(int number)
        {
            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        // Strong Number
        public static bool IsStrongNumber(int number)
        {
            int temp = number;
            int sum = 0;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += Factorial(digit);
                temp /= 10;
            }

            return sum == number;
        }
    }
}