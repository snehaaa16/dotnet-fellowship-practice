using System;

namespace _04_Methods.Level2
{
    public class SumOfNaturalNumbersRecursion
    {
        public static int FindSumRecursion(int n)
        {
            if (n == 1)
                return 1;

            return n + FindSumRecursion(n - 1);
        }

        public static int FindSumFormula(int n)
        {
            return n * (n + 1) / 2;
        }
    }
}