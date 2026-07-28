using System;

namespace _04_Methods.Level1
{
    public class TrigonometricFunctions
    {
        public static double[] CalculateTrigonometricFunctions(double angle)
        {
            double radians = angle * Math.PI / 180;

            double sine = Math.Sin(radians);
            double cosine = Math.Cos(radians);
            double tangent = Math.Tan(radians);

            return new double[] { sine, cosine, tangent };
        }
    }
}