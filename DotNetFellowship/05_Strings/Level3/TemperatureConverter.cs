using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Strings.Level3
{
    internal class TemperatureConverter
    {
        public static void ConvertTemperature()
        {
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");

            Console.Write("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Temperature: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Fahrenheit = " + CelsiusToFahrenheit(temperature));
                    break;

                case 2:
                    Console.WriteLine("Celsius = " + FahrenheitToCelsius(temperature));
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
