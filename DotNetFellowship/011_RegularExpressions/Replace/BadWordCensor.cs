using System;
using System.Text.RegularExpressions;

namespace _011_RegularExpressions.Replace;

public class BadWordCensor
{
    // Pattern:
    // \b(badword|ugly|stupid)\b : Matches specific bad words with word boundaries
    private const string Pattern = @"\b(badword|ugly|stupid)\b";

    public void Demo()
    {
        Console.WriteLine("\n--- BadWordCensor ---");
        Console.WriteLine($"Regex Pattern: {Pattern}");
        
        string input = "This is a stupid idea and very ugly.";
        Console.WriteLine($"Input: \"{input}\"");
        
        // Use RegexOptions.IgnoreCase to ensure case-insensitive matching
        string output = Regex.Replace(input, Pattern, "****", RegexOptions.IgnoreCase);
        Console.WriteLine($"Output: \"{output}\"");
    }
}
