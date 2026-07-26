using System;

namespace _03_Arrays.Level1.Exercises
{
    internal class StudentGradeCalculator
    {
        public static void CalculateGrade(int[,] marks)
        {
            double[] percentage = new double[marks.GetLength(0)];
            string[] grade = new string[marks.GetLength(0)];

            for (int i = 0; i < marks.GetLength(0); i++)
            {
                percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

                if (percentage[i] >= 80)
                {
                    grade[i] = "A";
                }
                else if (percentage[i] >= 70)
                {
                    grade[i] = "B";
                }
                else if (percentage[i] >= 60)
                {
                    grade[i] = "C";
                }
                else if (percentage[i] >= 50)
                {
                    grade[i] = "D";
                }
                else if (percentage[i] >= 40)
                {
                    grade[i] = "E";
                }
                else
                {
                    grade[i] = "R";
                }
            }

            Console.WriteLine("\nPhysics\tChemistry\tMaths\tPercentage\tGrade");

            for (int i = 0; i < marks.GetLength(0); i++)
            {
                Console.WriteLine(marks[i, 0] + "\t" + marks[i, 1] + "\t\t" + marks[i, 2] + "\t" + Math.Round(percentage[i], 2) + "%\t\t" + grade[i]);
            }
        }
    }
}