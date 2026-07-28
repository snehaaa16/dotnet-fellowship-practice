using System;

namespace _04_Methods.Level2
{
    public class NumberAnalyzer
    {
        public static bool IsPositive(int number)
        {
            return number >= 0;
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static int CompareNumbers(int number1, int number2)
        {
            if (number1 > number2)
                return 1;
            else if (number1 == number2)
                return 0;
            else
                return -1;
        }
    }
}