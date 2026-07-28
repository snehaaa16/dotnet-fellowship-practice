using System;

namespace _04_Methods.Level3
{
    public class MatrixOperations2
    {
        // Determinant of 2x2 Matrix
        public static double FindDeterminant2x2(int[,] matrix)
        {
            return (matrix[0, 0] * matrix[1, 1]) -
                   (matrix[0, 1] * matrix[1, 0]);
        }

        // Determinant of 3x3 Matrix
        public static double FindDeterminant3x3(int[,] matrix)
        {
            double determinant =
                matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
              - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
              + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

            return determinant;
        }

        // Inverse of 2x2 Matrix
        public static double[,] FindInverse2x2(int[,] matrix)
        {
            double determinant = FindDeterminant2x2(matrix);

            if (determinant == 0)
            {
                Console.WriteLine("Inverse does not exist.");
                return null;
            }

            double[,] inverse = new double[2, 2];

            inverse[0, 0] = matrix[1, 1] / determinant;
            inverse[0, 1] = -matrix[0, 1] / determinant;
            inverse[1, 0] = -matrix[1, 0] / determinant;
            inverse[1, 1] = matrix[0, 0] / determinant;

            return inverse;
        }

        // Inverse of 3x3 Matrix
        public static double[,] FindInverse3x3(int[,] matrix)
        {
            double determinant = FindDeterminant3x3(matrix);

            if (determinant == 0)
            {
                Console.WriteLine("Inverse does not exist.");
                return null;
            }

            double[,] inverse = new double[3, 3];

            inverse[0, 0] = ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1])) / determinant;
            inverse[0, 1] = ((matrix[0, 2] * matrix[2, 1]) - (matrix[0, 1] * matrix[2, 2])) / determinant;
            inverse[0, 2] = ((matrix[0, 1] * matrix[1, 2]) - (matrix[0, 2] * matrix[1, 1])) / determinant;

            inverse[1, 0] = ((matrix[1, 2] * matrix[2, 0]) - (matrix[1, 0] * matrix[2, 2])) / determinant;
            inverse[1, 1] = ((matrix[0, 0] * matrix[2, 2]) - (matrix[0, 2] * matrix[2, 0])) / determinant;
            inverse[1, 2] = ((matrix[0, 2] * matrix[1, 0]) - (matrix[0, 0] * matrix[1, 2])) / determinant;

            inverse[2, 0] = ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0])) / determinant;
            inverse[2, 1] = ((matrix[0, 1] * matrix[2, 0]) - (matrix[0, 0] * matrix[2, 1])) / determinant;
            inverse[2, 2] = ((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0])) / determinant;

            return inverse;
        }

        // Display Double Matrix
        public static void DisplayMatrix(double[,] matrix)
        {
            if (matrix == null)
            {
                return;
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(Math.Round(matrix[row, column], 2) + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}