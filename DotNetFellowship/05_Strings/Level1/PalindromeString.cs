using System;

namespace _05_Strings.Level1
{
    internal class PalindromeString
    {
        public static void CheckPalindrome(string str)
        {
            string reversed = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }

            if (str == reversed)
            {
                Console.WriteLine("The string is a Palindrome.");
            }
            else
            {
                Console.WriteLine("The string is Not a Palindrome.");
            }
        }
    }
}