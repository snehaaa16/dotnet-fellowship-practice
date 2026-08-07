using System;
using System.Text.RegularExpressions;

namespace _011_RegularExpressions.Extraction;

public class DateExtractor
{
    // Pattern:
    // \b : Word boundary
    // (0[1-9]|[12][0-9]|3[01]) : Day 01-31
    // / : Literal slash
    // (0[1-9]|1[0-2]) : Month 01-12
    // / : Literal slash
    // \d{4} : 4 digit year
    // \b : Word boundary
    private const string Pattern = @"\b(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}\b";

    public void Demo()
    {
        Console.WriteLine("\n--- DateExtractor ---");
        Console.WriteLine($"Regex Pattern: {Pattern}");
        
        string input = "Today's date is 15/08/2026, yesterday was 14/08/2026. Invalid: 32/13/2026";
        Console.WriteLine($"Input: {input}");
        
        var matches = Regex.Matches(input, Pattern);
        Console.WriteLine("Output:");
        foreach (Match match in matches)
        {
            Console.WriteLine($"  Found: {match.Value}");
        }
    }
}
