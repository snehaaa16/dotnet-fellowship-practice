using System;
namespace _02_ControlFlow.Level2.Exercises
{
    internal class MultiplesBelow100
    {
        public static void PrintMultiples(int number)
        {
            for (int i = 100; i >= 1; i--)
            {
                if (i % number == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}