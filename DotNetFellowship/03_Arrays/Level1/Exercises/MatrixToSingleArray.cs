using System;

namespace _03_Arrays.Level1.Exercises
{
    internal class MatrixToSingleArray
    {
        public static int[] ConvertToSingleArray(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[] array = new int[rows * columns];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[index] = matrix[i, j];
                    index++;
                }
            }

            return array;
        }
    }
}