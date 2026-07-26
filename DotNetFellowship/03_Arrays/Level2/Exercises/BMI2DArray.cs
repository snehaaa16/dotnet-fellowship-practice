using System;

namespace _03_Arrays.Level1.Exercises
{
    internal class BMI2DArray
    {
        public static void CalculateBMI(double[][] personData)
        {
            string[] weightStatus = new string[personData.Length];

            for (int i = 0; i < personData.Length; i++)
            {
                double heightInMeter = personData[i][1] / 100;
                personData[i][2] = personData[i][0] / (heightInMeter * heightInMeter);

                if (personData[i][2] <= 18.4)
                {
                    weightStatus[i] = "Underweight";
                }
                else if (personData[i][2] <= 24.9)
                {
                    weightStatus[i] = "Normal";
                }
                else if (personData[i][2] <= 39.9)
                {
                    weightStatus[i] = "Overweight";
                }
                else
                {
                    weightStatus[i] = "Obese";
                }
            }

            Console.WriteLine("\nWeight\tHeight\tBMI\tStatus");

            for (int i = 0; i < personData.Length; i++)
            {
                Console.WriteLine(personData[i][0] + "\t" + personData[i][1] + "\t" + Math.Round(personData[i][2], 2) + "\t" + weightStatus[i]);
            }
        }
    }
}