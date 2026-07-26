using System;

namespace _03_Arrays.Level1.Exercises
{
    internal class BMIArray
    {
        public static void CalculateBMI(double[] weight, double[] height)
        {
            double[] bmi = new double[weight.Length];
            string[] status = new string[weight.Length];

            for (int i = 0; i < weight.Length; i++)
            {
                double heightInMeter = height[i] / 100;
                bmi[i] = weight[i] / (heightInMeter * heightInMeter);

                if (bmi[i] <= 18.4)
                {
                    status[i] = "Underweight";
                }
                else if (bmi[i] <= 24.9)
                {
                    status[i] = "Normal";
                }
                else if (bmi[i] <= 39.9)
                {
                    status[i] = "Overweight";
                }
                else
                {
                    status[i] = "Obese";
                }
            }

            Console.WriteLine("\nHeight\tWeight\tBMI\tStatus");

            for (int i = 0; i < weight.Length; i++)
            {
                Console.WriteLine(height[i] + "\t" + weight[i] + "\t" + Math.Round(bmi[i], 2) + "\t" + status[i]);
            }
        }
    }
}