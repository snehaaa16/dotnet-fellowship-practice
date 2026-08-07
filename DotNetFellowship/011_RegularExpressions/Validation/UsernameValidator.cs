using System;
using System.Text.RegularExpressions;

namespace _011_RegularExpressions.Validation;

public class UsernameValidator
{
    // Pattern: 
    // ^[a-zA-Z] : Starts with a letter
    // [a-zA-Z0-9_]{4,14}$ : Followed by 4 to 14 letters, digits, or underscores (making total length 5-15)
    private const string Pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";

    public void Demo()
    {
        Console.WriteLine("\n--- UsernameValidator ---");
        Console.WriteLine($"Regex Pattern: {Pattern}");
        
        string[] inputs = { "user_123", "123user", "us", "validName1", "invalid-name!" };
        foreach (var input in inputs)
        {
            bool isValid = Regex.IsMatch(input, Pattern);
            Console.WriteLine($"Input: {input, -15} Output: {isValid}");
        }
    }
}
