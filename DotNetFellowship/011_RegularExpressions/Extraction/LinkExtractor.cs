using System;
using System.Text.RegularExpressions;

namespace _011_RegularExpressions.Extraction;

public class LinkExtractor
{
    // Pattern:
    // https?:// : Matches http:// or https://
    // [a-zA-Z0-9.-]+ : Matches domain
    // \.[a-zA-Z]{2,} : Matches TLD
    // (/\S*)? : Matches optional path (non-whitespace characters)
    private const string Pattern = @"https?://[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}(/\S*)?";

    public void Demo()
    {
        Console.WriteLine("\n--- LinkExtractor ---");
        Console.WriteLine($"Regex Pattern: {Pattern}");
        
        string input = "Visit https://google.com or http://www.example.org/path?query=1 for details.";
        Console.WriteLine($"Input: {input}");
        
        var matches = Regex.Matches(input, Pattern);
        Console.WriteLine("Output:");
        foreach (Match match in matches)
        {
            Console.WriteLine($"  Found: {match.Value}");
        }
    }
}
