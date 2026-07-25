using System;
namespace _02_ControlFlow.Level2.Exercises
{
    internal class GreatestFactor
    {
        public static int FindGreatestFactor(int number)
        {
            int greatestFactor = 1;
            for (int i = number - 1; i >= 1; i--)
            {
                if (number % i == 0)
                {
                    greatestFactor = i;
                    break;
                }
            }
            return greatestFactor;
        }
    }
}