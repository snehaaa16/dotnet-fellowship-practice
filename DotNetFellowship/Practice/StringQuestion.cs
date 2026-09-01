using System;
using System.Collections.Generic;
using System.Text;


//Convert a number to a string, the contents of which depend on the number's factors.

//If the number has 3 as a factor, output 'Pling'.
//If the number has 5 as a factor, output 'Plang'.
//If the number has 7 as a factor, output 'Plong'.
//If the number does not have 3, 5, or 7 as a factor, just pass the number's digits straight through.
//(Example :28 has 7 as a factor, but not 3 or 5, so the result would be “Plong”.
//30 has both 3 and 5 as factors, but not 7, so the result would be “PlingPlang”.
//34 is not factored by 3, 5, or 7, so the result would be “34”.)

namespace Practice
{
    public class StringQuestion
    {
        static string ConvertNumToString(int number)
        {
            string ans = "";
            if (number % 3 == 0) ans += "Pling";
            else if (number % 5 == 0) ans += "Plang";
            else if (number % 7 == 0) ans += "Plong";
            else
            {
                ans += number.ToString();
            }
            return ans;
        }
        static void Main(String[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ConvertNumToString(number));
        }
    }
}
