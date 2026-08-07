using System;
using System.Text.RegularExpressions;

namespace _011_RegularExpressions.Search;

public class RepeatingWordFinder
{
    // Pattern:
    // \b(\w+)\s+\1\b : Matches a word, followed by spaces, followed by the same word
    private const string Pattern = @"\b(\w+)\s+\1\b";

    public void Demo()
    {
        Console.WriteLine("\n--- RepeatingWordFinder ---");
        Console.WriteLine($"Regex Pattern: {Pattern}");
        
        string input = "This is is a repeated repeated word.";
        Console.WriteLine($"Input: {input}");
        
        var matches = Regex.Matches(input, Pattern, RegexOptions.IgnoreCase);
        Console.WriteLine("Output:");
        foreach (Match match in matches)
        {
            // Group 1 contains the matched word
            Console.WriteLine($"  Found repeating word: {match.Groups[1].Value}");
        }
    }
}
