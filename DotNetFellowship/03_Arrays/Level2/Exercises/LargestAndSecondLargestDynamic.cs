using System;

namespace _03_Arrays.Level1.Exercises
{
    internal class LargestAndSecondLargestDynamic
    {
        public static void FindLargestAndSecondLargest(long number)
        {
            int maxDigit = 10;
            int[] digits = new int[maxDigit];
            int index = 0;

            while (number != 0)
            {
                if (index == maxDigit)
                {
                    maxDigit += 10;
                    int[] temp = new int[maxDigit];

                    for (int i = 0; i < digits.Length; i++)
                    {
                        temp[i] = digits[i];
                    }

                    digits = temp;
                }

                digits[index] = (int)(number % 10);
                number /= 10;
                index++;
            }

            int largest = 0;
            int secondLargest = 0;

            for (int i = 0; i < index; i++)
            {
                if (digits[i] > largest)
                {
                    secondLargest = largest;
                    largest = digits[i];
                }
                else if (digits[i] > secondLargest && digits[i] != largest)
                {
                    secondLargest = digits[i];
                }
            }

            Console.WriteLine("Largest Digit = " + largest);
            Console.WriteLine("Second Largest Digit = " + secondLargest);
        }
    }
}