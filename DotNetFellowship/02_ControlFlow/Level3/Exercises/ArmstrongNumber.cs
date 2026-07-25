using System;
namespace _02_ControlFlow.Level2.Exercises
{
    internal class ArmstrongNumber
    {
        public static bool IsArmstrong(int number)
        {
            int originalNumber = number;
            int sum = 0;
            while (originalNumber != 0)
            {
                int digit = originalNumber % 10;
                sum += digit * digit * digit;
                originalNumber /= 10;
            }
            return sum == number;
        }
    }
}