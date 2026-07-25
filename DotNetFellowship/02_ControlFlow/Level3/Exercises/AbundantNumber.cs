using System;
namespace _02_ControlFlow.Level2.Exercises
{
    internal class AbundantNumber
    {
        public static bool IsAbundantNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if (sum > number)
            {
                return true;
            }
            return false;
        }
    }
}