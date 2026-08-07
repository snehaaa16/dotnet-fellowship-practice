using System;
using System.Text.RegularExpressions;

namespace _011_RegularExpressions.Validation;

public class CreditCardValidator
{
    // Pattern:
    // ^4\d{15}$ : Starts with 4, followed by 15 digits (Visa)
    // | : OR
    // ^5\d{15}$ : Starts with 5, followed by 15 digits (MasterCard)
    private const string Pattern = @"^4\d{15}$|^5\d{15}$";

    public void Demo()
    {
        Console.WriteLine("\n--- CreditCardValidator ---");
        Console.WriteLine($"Regex Pattern: {Pattern}");
        
        string[] inputs = { "4123456789123456", "5123456789123456", "6123456789123456", "4123" };
        foreach (var input in inputs)
        {
            bool isValid = Regex.IsMatch(input, Pattern);
            Console.WriteLine($"Input: {input, -17} Output: {isValid}");
        }
    }
}
