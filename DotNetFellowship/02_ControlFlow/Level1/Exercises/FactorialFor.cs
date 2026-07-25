using System;
namespace _02_ControlFlow.Level1.Exercises
{
    internal class FactorialFor
    {
        public static long CalculateFactorial(int number)
        {
            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}