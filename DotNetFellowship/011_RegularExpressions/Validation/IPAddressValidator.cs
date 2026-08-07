using System;
using System.Text.RegularExpressions;

namespace _011_RegularExpressions.Validation;

public class IPAddressValidator
{
    // Pattern:
    // (25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?) : Matches 0-255
    // Repeated 4 times separated by literal dot
    private const string Pattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

    public void Demo()
    {
        Console.WriteLine("\n--- IPAddressValidator ---");
        Console.WriteLine($"Regex Pattern: {Pattern}");
        
        string[] inputs = { "192.168.1.1", "255.255.255.255", "256.100.50.0", "127.0.0.1", "ip.address" };
        foreach (var input in inputs)
        {
            bool isValid = Regex.IsMatch(input, Pattern);
            Console.WriteLine($"Input: {input, -15} Output: {isValid}");
        }
    }
}
