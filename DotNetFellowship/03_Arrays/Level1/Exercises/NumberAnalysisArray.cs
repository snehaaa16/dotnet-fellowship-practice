using System;

namespace _03_Arrays.Level1.Exercises
{
    internal class NumberAnalysisArray
    {
        public static void AnalyzeNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.WriteLine(numbers[i] + " is Positive and Even");
                    }
                    else
                    {
                        Console.WriteLine(numbers[i] + " is Positive and Odd");
                    }
                }
                else if (numbers[i] < 0)
                {
                    Console.WriteLine(numbers[i] + " is Negative");
                }
                else
                {
                    Console.WriteLine(numbers[i] + " is Zero");
                }
            }

            if (numbers[0] > numbers[numbers.Length - 1])
            {
                Console.WriteLine("First element is greater than the last element.");
            }
            else if (numbers[0] < numbers[numbers.Length - 1])
            {
                Console.WriteLine("First element is less than the last element.");
            }
            else
            {
                Console.WriteLine("First element is equal to the last element.");
            }
        }
    }
}
