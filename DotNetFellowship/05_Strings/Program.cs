//Write a C# program to count the number of vowels and consonants in a given string.
using _05_Strings.Level1;
using _05_Strings.Level2;
using _05_Strings.Level3;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.Write("Enter a string: ");
string count = Console.ReadLine();
CountVowelsandConsonants.Count(count);

//Write a C# program to reverse a given string without using any built-in reverse functions.
Console.Write("Enter a string: ");
string rev = Console.ReadLine();
ReverseString.Reverse(rev);

//Write a C# program to check if a given string is a palindrome (a string that reads the
//same forward and backward).
Console.Write("Enter a string: ");
string palindrome = Console.ReadLine();

PalindromeString.CheckPalindrome(palindrome);

//Write a C# program to remove all duplicate characters from a given string and return the
//modified string.
Console.Write("Enter a string: ");
string removeDuplicate = Console.ReadLine();

RemoveDuplicates.RemoveDuplicateCharacters(removeDuplicate);

//Write a C# program that takes a sentence as input and returns the longest word in the
//sentence.
Console.Write("Enter a sentence: ");
string sentence = Console.ReadLine();

LongestWord.FindLongestWord(sentence);

//Write a C# program to count how many times a given substring occurs in a string.
Console.Write("Enter a string: ");
string str = Console.ReadLine();

Console.Write("Enter the substring: ");
string sub = Console.ReadLine();

SubstringOccurrences.CountOccurrences(str, sub);

//Write a C# program to toggle the case of each character in a given string. Convert
//uppercase letters to lowercase and vice versa.
Console.Write("Enter a string: ");
string toggle = Console.ReadLine();

ToggleCase.Toggle(toggle);

//Write a C# program to compare two strings lexicographically (dictionary order) without
//using built-in compare methods.
//Example Input:
//String 1: "apple"
//String 2: "banana"
//Expected Output:
//"apple" comes before "banana" in lexicographical order
Console.Write("Enter first string: ");
string str1 = Console.ReadLine();

Console.Write("Enter second string: ");
string str2 = Console.ReadLine();

CompareStrings.Compare(str1, str2);

//Write a C# program to find the most frequent character in a string.
//Example Input:
//String: "success"
//Expected Output:
//Most Frequent Character: 's'
Console.Write("Enter a string: ");
string frequentChar = Console.ReadLine();

MostFrequentCharacter.FindMostFrequent(frequentChar);

//Write a C# program to remove all occurrences of a specific character from a string.
//Example Input:
//String: "Hello World"
//Character to Remove: 'l'
//Expected Output:
//Modified String: "Heo Word"
Console.Write("Enter a string: ");
string fullName = Console.ReadLine();

Console.Write("Enter character to remove: ");
char ch = Convert.ToChar(Console.ReadLine());

RemoveSpecificCharacter.RemoveCharacter(fullName, ch);

//Write a C# program that accepts two strings from the user and checks if the two
//strings are anagrams of each other (i.e., whether they contain the same characters in any
//order).
Console.Write("Enter first string: ");
string strg1 = Console.ReadLine();

Console.Write("Enter second string: ");
string strg2 = Console.ReadLine();

AnagramChecker.CheckAnagram(str1, str2);

//Write a replace method in C# that replaces a given word with another word in a
//sentence:
Console.Write("Enter a sentence: ");
string sen = Console.ReadLine();

Console.Write("Enter the word to replace: ");
string oldWord = Console.ReadLine();

Console.Write("Enter the new word: ");
string newWord = Console.ReadLine();

ReplaceWord.Replace(sen, oldWord, newWord);

//Write a program that displays the current time in different time zones:
//● GMT(Greenwich Mean Time)
//● IST(Indian Standard Time)
//● PST(Pacific Standard Time)
Timezone.DisplayTimeZones();

//Create a program that:
//● Takes a date input and adds 7 days, 1 month, and 2 years to it.
//● Then subtracts 3 weeks from the result.
DateArithmetic.CalculateDate();

//Write a program that:
//● Displays the current date in three different formats:
//o dd/MM/yyyy
//o yyyy-MM-dd
//o EEE, MMM dd, yyyy
DateFormatting.ShowFormats();

//Write a program that:
//● Takes two date inputs and compares them to check if the first date is
//before, after, or the same as the second date.
DateComparison.CompareDates();

//Write a program where the user thinks of a number between 1 and 100, and the computer
//tries to guess the number by generating random guesses.
//● The user provides feedback by indicating whether the guess is high, low, or correct.
//● The program should be modular, with different functions for generating guesses,
//receiving user feedback, and determining the next guess.
NumberGuessingGame.StartGame();

//Write a program that takes three integer inputs from the user and finds the maximum of the
//three numbers.
//● Ensure your program follows best practices for organizing code into modular
//functions, such as separate functions for taking input and calculating the maximum
//value.
MaximumOfThree.FindMaximum();

//Create a program that checks whether a given number is a prime number.
//● The program should use a separate function to perform the prime check and return
//the result.
PrimeNumberChecker.CheckPrime();


//Write a program that generates the Fibonacci sequence up to a specified number of terms
//entered by the user.
//● Organize the code by creating a function that calculates and prints the Fibonacci
//sequence.
FibonacciGenerator.GenerateSeries();


//Write a program that checks if a given string is a palindrome (a word, phrase, or sequence
//that reads the same backward as forward).
//● Break the program into functions for input, checking the palindrome condition, and
//displaying the result.
PalindromeChecker.CheckPalindrome();


//Write a program that calculates the factorial of a number using a recursive function.
//● Include modular code to separate input, calculation, and output processes.
FactorialRecursion.CalculateFactorial();

//Create a program that calculates the Greatest Common Divisor (GCD) and Least Common
//Multiple (LCM) of two numbers using functions.
//● Use separate functions for GCD and LCM calculations, showcasing how modular code
//works.
GcdLcmCalculator.Calculate();


//Write a program that converts temperatures between Fahrenheit and Celsius.
//● The program should have separate functions for converting from Fahrenheit to
//Celsius and from Celsius to Fahrenheit.
TemperatureConverter.ConvertTemperature();

//Write a program that performs basic mathematical operations (addition, subtraction,
//multiplication, division) based on user input.
//● Each operation should be performed in its own function, and the program should
//prompt the user to choose which operation to perform.
BasicCalculator.StartCalculator();