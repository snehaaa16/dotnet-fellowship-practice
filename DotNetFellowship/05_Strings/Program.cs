//Write a C# program to count the number of vowels and consonants in a given string.
using _05_Strings.Level1;
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