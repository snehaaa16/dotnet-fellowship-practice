using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Strings.Level2
{
    internal class DateComparison
    {
        public static void CompareDates()
        {
            Console.Write("Enter First Date (dd-MM-yyyy): ");
            DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

            Console.Write("Enter Second Date (dd-MM-yyyy): ");
            DateTime date2 = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

            int result = DateTime.Compare(date1, date2);

            if (result < 0)
            {
                Console.WriteLine("First date is before second date.");
            }
            else if (result > 0)
            {
                Console.WriteLine("First date is after second date.");
            }
            else
            {
                Console.WriteLine("Both dates are the same.");
            }
        }
    }
}
