using System;
namespace _02_ControlFlow.Level2.Exercises
{
    internal class CountDigits
    {
        public static int FindDigitCount(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            int count = 0;
            while (number != 0)
            {
                number /= 10;
                count++;
            }
            return count;
        }
    }
}