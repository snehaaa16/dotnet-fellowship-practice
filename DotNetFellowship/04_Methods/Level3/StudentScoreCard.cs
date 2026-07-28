using System;

namespace _04_Methods.Level3
{
    public class StudentScoreCard
    {
        // Generate Random Marks
        public static int[,] GenerateMarks(int studentCount)
        {
            Random random = new Random();

            int[,] marksData = new int[studentCount, 3];

            for (int studentIndex = 0; studentIndex < studentCount; studentIndex++)
            {
                marksData[studentIndex, 0] = random.Next(40, 101); // Physics
                marksData[studentIndex, 1] = random.Next(40, 101); // Chemistry
                marksData[studentIndex, 2] = random.Next(40, 101); // Maths
            }

            return marksData;
        }

        // Calculate Total, Average and Percentage
        public static double[,] CalculateResult(int[,] marksData)
        {
            int studentCount = marksData.GetLength(0);

            double[,] resultData = new double[studentCount, 3];

            for (int studentIndex = 0; studentIndex < studentCount; studentIndex++)
            {
                int totalMarks =
                    marksData[studentIndex, 0] +
                    marksData[studentIndex, 1] +
                    marksData[studentIndex, 2];

                double averageMarks = totalMarks / 3.0;
                double percentage = totalMarks / 3.0;

                resultData[studentIndex, 0] = totalMarks;
                resultData[studentIndex, 1] = Math.Round(averageMarks, 2);
                resultData[studentIndex, 2] = Math.Round(percentage, 2);
            }

            return resultData;
        }

        // Display Score Card
        public static void DisplayScoreCard(int[,] marksData, double[,] resultData)
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");
            Console.WriteLine("-----------------------------------------------------------------------");

            for (int studentIndex = 0; studentIndex < marksData.GetLength(0); studentIndex++)
            {
                Console.WriteLine(
                    $"{studentIndex + 1}\t" +
                    $"{marksData[studentIndex, 0]}\t" +
                    $"{marksData[studentIndex, 1]}\t\t" +
                    $"{marksData[studentIndex, 2]}\t" +
                    $"{resultData[studentIndex, 0]}\t" +
                    $"{resultData[studentIndex, 1]}\t" +
                    $"{resultData[studentIndex, 2]}");
            }
        }
    }
}