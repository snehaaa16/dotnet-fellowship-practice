using System;
namespace _02_ControlFlow.Level2.Exercises
{
    internal class FactorsOfNumber
    {
        public static void PrintFactors(int number)
        {
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}