using System;
using System.Text.RegularExpressions;

namespace _011_RegularExpressions.Extraction;

public class ProgrammingLanguageExtractor
{
    // Pattern:
    // \b : Word boundary
    // (Java|Python|JavaScript|Go) : Alternation of specific languages
    // \b : Word boundary
    private const string Pattern = @"\b(Java|Python|JavaScript|Go)\b";

    public void Demo()
    {
        Console.WriteLine("\n--- ProgrammingLanguageExtractor ---");
        Console.WriteLine($"Regex Pattern: {Pattern}");
        
        string input = "I am learning Java and Python, but my friend prefers JavaScript and Go.";
        Console.WriteLine($"Input: {input}");
        
        var matches = Regex.Matches(input, Pattern);
        Console.WriteLine("Output:");
        foreach (Match match in matches)
        {
            Console.WriteLine($"  Found: {match.Value}");
        }
    }
}
