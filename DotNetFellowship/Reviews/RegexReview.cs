using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Reviews
{
    internal class RegexReview
    {
        static void Main()
        {
            string input = "Sgsg$2526";
            string regex = @"^([A-Z][a-z]{3})(\.|@|_|\^|\$)([0-9]{4})$";

            bool var = Regex.IsMatch(input, regex);
            Console.WriteLine(var);
        }
    }
}
