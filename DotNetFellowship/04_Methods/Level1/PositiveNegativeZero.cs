using System;

namespace _04_Methods.Level1
{
    public class PositiveNegativeZero
    {
        public static int CheckNumber(int number)
        {
            if (number > 0)
                return 1;
            else if (number < 0)
                return -1;
            else
                return 0;
        }
    }
}