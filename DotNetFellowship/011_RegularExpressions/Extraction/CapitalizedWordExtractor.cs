using System;
using System.Text.RegularExpressions;

namespace _011_RegularExpressions.Extraction;

public class CapitalizedWordExtractor
{
    // Pattern:
    // \b : Word boundary
    // [A-Z] : One uppercase letter
    // [a-z]* : Zero or more lowercase letters
    // \b : Word boundary
    private const string Pattern = @"\b[A-Z][a-z]*\b";

    public void Demo()
    {
        Console.WriteLine("\n--- CapitalizedWordExtractor ---");
        Console.WriteLine($"Regex Pattern: {Pattern}");
        
        string input = "The Eiffel Tower is in Paris.";
        Console.WriteLine($"Input: {input}");
        
        var matches = Regex.Matches(input, Pattern);
        Console.WriteLine("Output:");
        foreach (Match match in matches)
        {
            Console.WriteLine($"  Found: {match.Value}");
        }
    }
}
