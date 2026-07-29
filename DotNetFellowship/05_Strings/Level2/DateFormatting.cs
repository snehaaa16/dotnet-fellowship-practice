using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Strings.Level2
{
    internal class DateFormatting
    {
        public static void ShowFormats()
        {
            DateTime today = DateTime.Now;

            Console.WriteLine("dd/MM/yyyy : " + today.ToString("dd/MM/yyyy"));
            Console.WriteLine("yyyy-MM-dd : " + today.ToString("yyyy-MM-dd"));
            Console.WriteLine("ddd, MMM dd, yyyy : " + today.ToString("ddd, MMM dd, yyyy"));
        }
    }
}
