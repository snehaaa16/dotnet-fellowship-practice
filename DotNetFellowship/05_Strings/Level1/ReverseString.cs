using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Strings.Level1
{
    internal class ReverseString
    {
        public static void Reverse(string str)
        {
            string reversed = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }

            Console.WriteLine("Reversed String: " + reversed);
        }
    }
}
