using System;

namespace _03_Arrays.Level1.Exercises
{
    internal class MultiplicationTableArray
    {
        public static int[] GenerateTable(int number)
        {
            int[] table = new int[10];

            for (int i = 1; i <= 10; i++)
            {
                table[i - 1] = number * i;
            }

            return table;
        }
    }
}