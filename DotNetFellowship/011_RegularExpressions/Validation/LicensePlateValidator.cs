using System;
using System.Text.RegularExpressions;

namespace _011_RegularExpressions.Validation;

public class LicensePlateValidator
{
    // Pattern:
    // ^[A-Z]{2} : Starts with exactly two uppercase letters
    // \d{4}$ : Ends with exactly four digits
    private const string Pattern = @"^[A-Z]{2}\d{4}$";

    public void Demo()
    {
        Console.WriteLine("\n--- LicensePlateValidator ---");
        Console.WriteLine($"Regex Pattern: {Pattern}");
        
        string[] inputs = { "AA1234", "AB123", "aB1234", "XYZ9999", "1234AA" };
        foreach (var input in inputs)
        {
            bool isValid = Regex.IsMatch(input, Pattern);
            Console.WriteLine($"Input: {input, -15} Output: {isValid}");
        }
    }
}
