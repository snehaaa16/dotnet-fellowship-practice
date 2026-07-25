using System;
namespace _02_ControlFlow.Level1.Exercises
{
    internal class OddEvenNumbers
    {
        public static void PrintOddEven(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is Even");
                }
                else
                {
                    Console.WriteLine(i + " is Odd");
                }
            }
        }
    }
}