using System;
namespace _02_ControlFlow.Level2.Exercises
{
    internal class PowerOfNumber
    {
        public static int FindPower(int number, int power)
        {
            int result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}