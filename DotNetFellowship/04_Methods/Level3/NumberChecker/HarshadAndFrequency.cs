using System;

namespace _04_Methods.Level3.NumberChecker
{
    public class HarshadAndFrequency
    {
        // Check Harshad Number
        public static bool IsHarshadNumber(int number)
        {
            int originalNumber = number;
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            if (originalNumber % sum == 0)
            {
                return true;
            }

            return false;
        }

        // Find Frequency of Digits
        public static int[] DigitFrequency(int number)
        {
            int[] frequency = new int[10];

            while (number > 0)
            {
                int digit = number % 10;
                frequency[digit]++;
                number /= 10;
            }

            return frequency;
        }

        // Display Frequency
        public static void DisplayFrequency(int[] frequency)
        {
            Console.WriteLine("\nDigit Frequency:");

            for (int digit = 0; digit < frequency.Length; digit++)
            {
                if (frequency[digit] > 0)
                {
                    Console.WriteLine(digit + " : " + frequency[digit]);
                }
            }
        }
    }
}