using System;

namespace _03_Arrays.Level1.Exercises
{
    internal class ReverseNumberUsingArray
    {
        public static void ReverseNumber(int number)
        {
            int temp = number;
            int digitCount = 0;

            while (temp != 0)
            {
                digitCount++;
                temp /= 10;
            }

            int[] digits = new int[digitCount];

            temp = number;

            for (int i = 0; i < digitCount; i++)
            {
                digits[i] = temp % 10;
                temp /= 10;
            }

            int[] reverseDigits = new int[digitCount];

            for (int i = 0; i < digitCount; i++)
            {
                reverseDigits[i] = digits[digitCount - 1 - i];
            }

            Console.Write("Reversed Number = ");

            for (int i = 0; i < reverseDigits.Length; i++)
            {
                Console.Write(reverseDigits[i]);
            }

            Console.WriteLine();
        }
    }
}