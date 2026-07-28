using System;

namespace _05_Strings.Level1
{
    internal class ReplaceWord
    {
        public static void Replace(string sentence, string oldWord, string newWord)
        {
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == oldWord)
                {
                    words[i] = newWord;
                }
            }

            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                result += words[i];

                if (i < words.Length - 1)
                {
                    result += " ";
                }
            }

            Console.WriteLine("Modified Sentence: " + result);
        }
    }
}