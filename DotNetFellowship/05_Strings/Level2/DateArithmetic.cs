using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Strings.Level2
{
    internal class DateArithmetic
    {
        public static void CalculateDate()
        {
            Console.Write("Enter Date (dd-MM-yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

            DateTime result = date
                .AddDays(7)
                .AddMonths(1)
                .AddYears(2)
                .AddDays(-21);

            Console.WriteLine("Final Date : " + result.ToString("dd-MM-yyyy"));
        }
    }
}
