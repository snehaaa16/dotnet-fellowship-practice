using System;
namespace _02_ControlFlow.Level2.Exercises
{
    internal class BMI
    {
        public static void CalculateBMI(double weight, double height)
        {
            double heightInMeter = height / 100;
            double bmi = weight / (heightInMeter * heightInMeter);
            Console.WriteLine("BMI = " + bmi);
            if (bmi < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("Normal Weight");
            }
            else if (bmi < 30)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            }
        }
    }
}