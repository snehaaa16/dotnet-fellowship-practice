using System;

namespace _04_Methods.Level2
{
    public class BMICalculator
    {
        public static void CalculateBMI(double[,] persons)
        {
            for (int i = 0; i < persons.GetLength(0); i++)
            {
                double heightInMeters = persons[i, 1] / 100;
                persons[i, 2] = persons[i, 0] / (heightInMeters * heightInMeters);
            }
        }

        public static string[] GetBMIStatus(double[,] persons)
        {
            string[] status = new string[persons.GetLength(0)];

            for (int i = 0; i < persons.GetLength(0); i++)
            {
                double bmi = persons[i, 2];

                if (bmi < 18.5)
                    status[i] = "Underweight";
                else if (bmi < 25)
                    status[i] = "Normal";
                else if (bmi < 30)
                    status[i] = "Overweight";
                else
                    status[i] = "Obese";
            }

            return status;
        }
    }
}