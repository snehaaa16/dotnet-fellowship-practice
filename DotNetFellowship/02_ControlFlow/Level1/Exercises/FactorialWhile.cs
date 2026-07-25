using System;
namespace _02_ControlFlow.Level1.Exercises
{
    internal class FactorialWhile
    {
        public static long CalculateFactorial(int number)
        {
            long factorial = 1;
            int i = 1;
            while (i <= number)
            {
                factorial *= i;
                i++;
            }
            return factorial;
        }
    }
}