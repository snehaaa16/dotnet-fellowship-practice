using System;

namespace _04_Methods.Level3
{
    public class MatrixOperations
    {
        // Generate Random Matrix
        public static int[,] GenerateMatrix(int rows, int columns)
        {
            Random random = new Random();

            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = random.Next(1, 10);
                }
            }

            return matrix;
        }

        // Display Matrix
        public static void DisplayMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Add Matrices
        public static int[,] AddMatrices(int[,] firstMatrix, int[,] secondMatrix)
        {
            int rows = firstMatrix.GetLength(0);
            int columns = firstMatrix.GetLength(1);

            int[,] resultMatrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    resultMatrix[row, column] =
                        firstMatrix[row, column] + secondMatrix[row, column];
                }
            }

            return resultMatrix;
        }

        // Subtract Matrices
        public static int[,] SubtractMatrices(int[,] firstMatrix, int[,] secondMatrix)
        {
            int rows = firstMatrix.GetLength(0);
            int columns = firstMatrix.GetLength(1);

            int[,] resultMatrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    resultMatrix[row, column] =
                        firstMatrix[row, column] - secondMatrix[row, column];
                }
            }

            return resultMatrix;
        }

        // Multiply Matrices
        public static int[,] MultiplyMatrices(int[,] firstMatrix, int[,] secondMatrix)
        {
            int rows = firstMatrix.GetLength(0);
            int columns = secondMatrix.GetLength(1);
            int common = firstMatrix.GetLength(1);

            int[,] resultMatrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    resultMatrix[row, column] = 0;

                    for (int index = 0; index < common; index++)
                    {
                        resultMatrix[row, column] +=
                            firstMatrix[row, index] *
                            secondMatrix[index, column];
                    }
                }
            }

            return resultMatrix;
        }

        // Transpose Matrix
        public static int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] transposeMatrix = new int[columns, rows];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    transposeMatrix[column, row] = matrix[row, column];
                }
            }

            return transposeMatrix;
        }
    }
}