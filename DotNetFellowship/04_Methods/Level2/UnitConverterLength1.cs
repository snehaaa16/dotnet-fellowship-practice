using System;

namespace _04_Methods.Level2
{
    public class UnitConverterLength1
    {
        public static double ConvertKmToMiles(double km)
        {
            return km * 0.621371;
        }

        public static double ConvertMilesToKm(double miles)
        {
            return miles * 1.60934;
        }

        public static double ConvertMetersToFeet(double meters)
        {
            return meters * 3.28084;
        }

        public static double ConvertFeetToMeters(double feet)
        {
            return feet * 0.3048;
        }
    }
}