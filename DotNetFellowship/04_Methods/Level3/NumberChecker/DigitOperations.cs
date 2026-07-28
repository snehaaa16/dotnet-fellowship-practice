using System;

namespace _04_Methods.Level3.NumberChecker
{
    public class DigitOperations
    {
        // Count Digits
        public static int CountDigits(int number)
        {
            int count = 0;

            while (number != 0)
            {
                count++;
                number /= 10;
            }

            return count;
        }

        // Sum of Digits
        public static int SumOfDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        // Reverse Number
        public static int ReverseNumber(int number)
        {
            int reverse = 0;

            while (number != 0)
            {
                int digit = number % 10;
                reverse = reverse * 10 + digit;
                number /= 10;
            }

            return reverse;
        }

        // Largest Digit
        public static int LargestDigit(int number)
        {
            int largest = 0;

            while (number != 0)
            {
                int digit = number % 10;

                if (digit > largest)
                {
                    largest = digit;
                }

                number /= 10;
            }

            return largest;
        }

        // Smallest Digit
        public static int SmallestDigit(int number)
        {
            int smallest = 9;

            while (number != 0)
            {
                int digit = number % 10;

                if (digit < smallest)
                {
                    smallest = digit;
                }

                number /= 10;
            }

            return smallest;
        }
    }
}