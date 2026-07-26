using System;

namespace _03_Arrays.Level1.Exercises
{
    internal class MultiplicationTableSixToNine
    {
        public static int[] GenerateTable(int number)
        {
            int[] multiplicationResult = new int[4];

            for (int i = 6; i <= 9; i++)
            {
                multiplicationResult[i - 6] = number * i;
            }

            return multiplicationResult;
        }
    }
}