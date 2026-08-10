using System;
using System.Collections.Generic;

class WordFrequencyCounter
{
    static void Main()
    {
        string text = "Hello world, hello Java!";

        text = text.ToLower();

        string[] words = text.Split(
            new char[] { ' ', ',', '!', '.', '?' },
            StringSplitOptions.RemoveEmptyEntries
        );

        Dictionary<string, int> frequency =
            new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (frequency.ContainsKey(word))
                frequency[word]++;
            else
                frequency[word] = 1;
        }

        foreach (var item in frequency)
            Console.WriteLine(item.Key + " : " + item.Value);
    }
}