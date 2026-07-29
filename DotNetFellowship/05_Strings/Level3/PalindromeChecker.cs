using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Strings.Level3
{
    internal class PalindromeChecker
    {
        public static void CheckPalindrome()
        {
            string text = ReadString();

            if (IsPalindrome(text))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }
        }

        static string ReadString()
        {
            Console.Write("Enter a String: ");
            return Console.ReadLine();
        }

        static bool IsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
