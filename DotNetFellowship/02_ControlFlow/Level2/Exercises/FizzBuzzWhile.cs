using System;
namespace _02_ControlFlow.Level2.Exercises
{
    internal class FizzBuzzWhile
    {
        public static void PrintFizzBuzz(int number)
        {
            int i = 0;
            while (i <= number)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}