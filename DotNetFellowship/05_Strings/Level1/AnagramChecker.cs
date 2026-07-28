using System;

namespace _05_Strings.Level1
{
    internal class AnagramChecker
    {
        public static void CheckAnagram(string str1, string str2)
        {
            str1 = str1.ToLower();
            str2 = str2.ToLower();

            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Not Anagrams");
                return;
            }

            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine("Not Anagrams");
                    return;
                }
            }

            Console.WriteLine("Strings are Anagrams");
        }
    }
}