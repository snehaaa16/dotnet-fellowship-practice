using System;
using System.Collections.Generic;

class InvertDictionary
{
    static void Main()
    {
        Dictionary<string, int> original =
            new Dictionary<string, int>
            {
                { "A", 1 },
                { "B", 2 },
                { "C", 1 }
            };

        Dictionary<int, List<string>> result =
            new Dictionary<int, List<string>>();

        foreach (var item in original)
        {
            if (!result.ContainsKey(item.Value))
                result[item.Value] = new List<string>();

            result[item.Value].Add(item.Key);
        }

        foreach (var item in result)
        {
            Console.WriteLine(
                item.Key + " = " +
                string.Join(", ", item.Value)
            );
        }
    }
}