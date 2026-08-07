using System;
using System.Text.RegularExpressions;

namespace _011_RegularExpressions.Validation;

public class SSNValidator
{
    // Pattern:
    // ^\d{3}-\d{2}-\d{4}$ : 3 digits, hyphen, 2 digits, hyphen, 4 digits
    private const string Pattern = @"^\d{3}-\d{2}-\d{4}$";

    public void Demo()
    {
        Console.WriteLine("\n--- SSNValidator ---");
        Console.WriteLine($"Regex Pattern: {Pattern}");
        
        string[] inputs = { "123-45-6789", "12-345-6789", "123456789", "999-99-9999" };
        foreach (var input in inputs)
        {
            bool isValid = Regex.IsMatch(input, Pattern);
            Console.WriteLine($"Input: {input, -15} Output: {isValid}");
        }
    }
}
