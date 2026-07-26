using System;

namespace _03_Arrays.Level1.Exercises
{
    internal class DigitFrequencyArray
    {
        public static void FindDigitFrequency(long number)
        {
            if (number < 0)
            {
                number = -number;
            }

            if (number == 0)
            {
                Console.WriteLine("Digit 0 = 1");
                return;
            }

            int digitCount = 0;
            long temp = number;

            while (temp != 0)
            {
                digitCount++;
                temp /= 10;
            }

            int[] digits = new int[digitCount];
            int[] frequency = new int[10];

            temp = number;

            for (int i = 0; i < digitCount; i++)
            {
                digits[i] = (int)(temp % 10);
                temp /= 10;
            }

            for (int i = 0; i < digitCount; i++)
            {
                frequency[digits[i]]++;
            }

            Console.WriteLine("Digit Frequencies:");

            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] > 0)
                {
                    Console.WriteLine("Digit " + i + " = " + frequency[i]);
                }
            }
        }
    }
}