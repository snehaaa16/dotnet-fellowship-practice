using System;

namespace _04_Methods.Level2
{
    public class UnitConverterLength2
    {
        public static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double ConvertPoundsToKilograms(double pounds)
        {
            return pounds * 0.453592;
        }

        public static double ConvertKilogramsToPounds(double kilograms)
        {
            return kilograms * 2.20462;
        }

        public static double ConvertGallonsToLiters(double gallons)
        {
            return gallons * 3.78541;
        }

        public static double ConvertLitersToGallons(double liters)
        {
            return liters * 0.264172;
        }
    }
}