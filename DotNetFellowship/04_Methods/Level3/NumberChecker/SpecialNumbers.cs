using System;

namespace _04_Methods.Level3.NumberChecker
{
    public class SpecialNumbers
    {
        // Prime Number
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        // Neon Number
        public static bool IsNeon(int number)
        {
            int square = number * number;
            int sum = 0;

            while (square > 0)
            {
                sum += square % 10;
                square /= 10;
            }

            return sum == number;
        }

        // Spy Number
        public static bool IsSpy(int number)
        {
            int sum = 0;
            int product = 1;
            int temp = number;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += digit;
                product *= digit;
                temp /= 10;
            }

            return sum == product;
        }

        // Automorphic Number
        public static bool IsAutomorphic(int number)
        {
            int square = number * number;
            int temp = number;

            while (temp > 0)
            {
                if (temp % 10 != square % 10)
                    return false;

                temp /= 10;
                square /= 10;
            }

            return true;
        }

        // Buzz Number
        public static bool IsBuzz(int number)
        {
            return (number % 7 == 0) || (number % 10 == 7);
        }
    }
}