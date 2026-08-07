using System;
using System.Text.RegularExpressions;

namespace _011_RegularExpressions.Replace;

public class MultipleSpaceReplacer
{
    // Pattern:
    // \s+ : Matches one or more whitespace characters
    private const string Pattern = @"\s+";

    public void Demo()
    {
        Console.WriteLine("\n--- MultipleSpaceReplacer ---");
        Console.WriteLine($"Regex Pattern: {Pattern}");
        
        string input = "This     is      sample";
        Console.WriteLine($"Input: \"{input}\"");
        
        string output = Regex.Replace(input, Pattern, " ");
        Console.WriteLine($"Output: \"{output}\"");
    }
}
