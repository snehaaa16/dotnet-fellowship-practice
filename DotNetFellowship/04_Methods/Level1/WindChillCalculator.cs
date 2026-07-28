using System;

namespace _04_Methods.Level1
{
    public class WindChillCalculator
    {
        public static double CalculateWindChill(double temperature, double windSpeed)
        {
            return 35.74 + (0.6215 * temperature) +
                   ((0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16));
        }
    }
}