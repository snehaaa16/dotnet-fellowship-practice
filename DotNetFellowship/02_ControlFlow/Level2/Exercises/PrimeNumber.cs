using System;
namespace _02_ControlFlow.Level2.Exercises
{
    internal class PrimeNumber
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            bool isPrime = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}