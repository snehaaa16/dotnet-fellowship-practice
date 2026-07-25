using System;
namespace _02_ControlFlow.Level2.Exercises
{
    internal class HarshadNumber
    {
        public static bool IsHarshadNumber(int number)
        {
            int originalNumber = number;
            int sum = 0;
            while (originalNumber != 0)
            {
                int digit = originalNumber % 10;
                sum += digit;
                originalNumber /= 10;
            }
            if (number % sum == 0)
            {
                return true;
            }
            return false;
        }
    }
}