using System;
using System.Text.RegularExpressions;

namespace _011_RegularExpressions.Validation;

public class HexColorValidator
{
    // Pattern:
    // ^# : Starts with '#'
    // ([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$ : Followed by exactly 6 OR 3 hex characters
    private const string Pattern = @"^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$";

    public void Demo()
    {
        Console.WriteLine("\n--- HexColorValidator ---");
        Console.WriteLine($"Regex Pattern: {Pattern}");
        
        string[] inputs = { "#FFA500", "#ff4500", "#123", "#GHI", "#1234" };
        foreach (var input in inputs)
        {
            bool isValid = Regex.IsMatch(input, Pattern);
            Console.WriteLine($"Input: {input, -15} Output: {isValid}");
        }
    }
}
