using System;

namespace _03_Arrays.Level1.Exercises
{
    internal class OddEvenArrays
    {
        public static void SeparateOddEven(int number)
        {
            int[] oddNumbers = new int[number / 2 + 1];
            int[] evenNumbers = new int[number / 2 + 1];

            int oddIndex = 0;
            int evenIndex = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers[evenIndex] = i;
                    evenIndex++;
                }
                else
                {
                    oddNumbers[oddIndex] = i;
                    oddIndex++;
                }
            }

            Console.WriteLine("Odd Numbers:");

            for (int i = 0; i < oddIndex; i++)
            {
                Console.WriteLine(oddNumbers[i]);
            }

            Console.WriteLine("Even Numbers:");

            for (int i = 0; i < evenIndex; i++)
            {
                Console.WriteLine(evenNumbers[i]);
            }
        }
    }
}