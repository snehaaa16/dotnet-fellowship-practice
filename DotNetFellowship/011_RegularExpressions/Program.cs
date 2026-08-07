using System;
using _011_RegularExpressions.Validation;
using _011_RegularExpressions.Extraction;
using _011_RegularExpressions.Replace;
using _011_RegularExpressions.Search;

namespace _011_RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("==========================\nVALIDATION\n==========================");
        new UsernameValidator().Demo();
        new LicensePlateValidator().Demo();
        new HexColorValidator().Demo();
        new IPAddressValidator().Demo();
        new CreditCardValidator().Demo();
        new SSNValidator().Demo();

        Console.WriteLine("\n==========================\nEXTRACTION\n==========================");
        new EmailExtractor().Demo();
        new CapitalizedWordExtractor().Demo();
        new DateExtractor().Demo();
        new LinkExtractor().Demo();
        new ProgrammingLanguageExtractor().Demo();
        new CurrencyExtractor().Demo();

        Console.WriteLine("\n==========================\nREPLACE\n==========================");
        new MultipleSpaceReplacer().Demo();
        new BadWordCensor().Demo();

        Console.WriteLine("\n==========================\nSEARCH\n==========================");
        new RepeatingWordFinder().Demo();
    }
}
