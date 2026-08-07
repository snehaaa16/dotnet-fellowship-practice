using System;
using System.Text.RegularExpressions;

namespace _011_RegularExpressions.Extraction;

public class CurrencyExtractor
{
    // Pattern:
    // \$ : Literal dollar sign
    // \d+ : One or more digits
    // (\.\d{2})? : Optional literal dot followed by exactly 2 digits
    private const string Pattern = @"\$\d+(\.\d{2})?";

    public void Demo()
    {
        Console.WriteLine("\n--- CurrencyExtractor ---");
        Console.WriteLine($"Regex Pattern: {Pattern}");
        
        string input = "The book costs $45.99 and the pen is $10.50. I also have $5 in cash.";
        Console.WriteLine($"Input: {input}");
        
        var matches = Regex.Matches(input, Pattern);
        Console.WriteLine("Output:");
        foreach (Match match in matches)
        {
            Console.WriteLine($"  Found: {match.Value}");
        }
    }
}
