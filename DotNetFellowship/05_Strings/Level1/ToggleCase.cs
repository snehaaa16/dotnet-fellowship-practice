using System;

namespace _05_Strings.Level1
{
    internal class ToggleCase
    {
        public static void Toggle(string str)
        {
            string result = "";

            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    result += char.ToLower(ch);
                }
                else if (char.IsLower(ch))
                {
                    result += char.ToUpper(ch);
                }
                else
                {
                    result += ch;
                }
            }

            Console.WriteLine("Toggled String: " + result);
        }
    }
}