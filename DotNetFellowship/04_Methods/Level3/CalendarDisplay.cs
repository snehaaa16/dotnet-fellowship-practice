using System;

namespace _04_Methods.Level3
{
    public class CalendarDisplay
    {
        // Month Names
        public static string GetMonthName(int month)
        {
            string[] months =
            {
                "January","February","March","April","May","June",
                "July","August","September","October","November","December"
            };

            return months[month - 1];
        }

        // Leap Year
        public static bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        // Number of Days
        public static int GetDaysInMonth(int month, int year)
        {
            int[] days =
            {
                31,28,31,30,31,30,31,31,30,31,30,31
            };

            if (month == 2 && IsLeapYear(year))
                return 29;

            return days[month - 1];
        }

        // Gregorian Algorithm
        public static int GetFirstDay(int month, int year)
        {
            int d = 1;

            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;

            int d0 = (d + x + (31 * m0) / 12) % 7;

            return d0;
        }

        // Display Calendar
        public static void DisplayCalendar(int month, int year)
        {
            Console.WriteLine();
            Console.WriteLine("      " + GetMonthName(month) + " " + year);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            int firstDay = GetFirstDay(month, year);
            int totalDays = GetDaysInMonth(month, year);

            // Initial Spaces
            for (int i = 0; i < firstDay; i++)
            {
                Console.Write("    ");
            }

            // Print Days
            for (int day = 1; day <= totalDays; day++)
            {
                Console.Write($"{day,3} ");

                if ((firstDay + day) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }
    }
}