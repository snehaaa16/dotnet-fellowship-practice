using System;
using System.Text.RegularExpressions;

namespace _011_RegularExpressions.Extraction;

public class EmailExtractor
{
    // Pattern:
    // [a-zA-Z0-9._%+-]+ : One or more valid email prefix characters
    // @ : Literal @ symbol
    // [a-zA-Z0-9.-]+ : Domain name
    // \. : Literal dot
    // [a-zA-Z]{2,} : TLD of at least 2 characters
    private const string Pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

    public void Demo()
    {
        Console.WriteLine("\n--- EmailExtractor ---");
        Console.WriteLine($"Regex Pattern: {Pattern}");
        
        string input = "Contact us at support@example.com or info@company.org for more details.";
        Console.WriteLine($"Input: {input}");
        
        var matches = Regex.Matches(input, Pattern);
        Console.WriteLine("Output:");
        foreach (Match match in matches)
        {
            Console.WriteLine($"  Found: {match.Value}");
        }
    }
}
