using System;

namespace _04_Methods.Level3.NumberChecker
{
    public class PalindromeAndReverse
    {
        // Count Digits
        public static int CountDigits(int number)
        {
            int count = 0;

            while (number > 0)
            {
                count++;
                number /= 10;
            }

            return count;
        }

        // Store Digits in Array
        public static int[] GetDigits(int number)
        {
            int count = CountDigits(number);
            int[] digits = new int[count];

            for (int i = count - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }

            return digits;
        }

        // Reverse Digits Array
        public static int[] ReverseDigits(int[] digits)
        {
            int[] reverse = new int[digits.Length];

            for (int i = 0; i < digits.Length; i++)
            {
                reverse[i] = digits[digits.Length - 1 - i];
            }

            return reverse;
        }

        // Compare Arrays
        public static bool CompareArrays(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
                return false;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    return false;
            }

            return true;
        }

        // Palindrome Number
        public static bool IsPalindrome(int[] digits)
        {
            int[] reverse = ReverseDigits(digits);
            return CompareArrays(digits, reverse);
        }

        // Duck Number
        public static bool IsDuckNumber(int[] digits)
        {
            for (int i = 1; i < digits.Length; i++)
            {
                if (digits[i] == 0)
                    return true;
            }

            return false;
        }
    }
}