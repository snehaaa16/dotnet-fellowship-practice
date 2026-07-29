using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Strings.Level3
{
    internal class NumberGuessingGame
    {
        public static void StartGame()
        {
            int low = 1;
            int high = 100;

            Console.WriteLine("Think of a number between 1 and 100.");
            Console.WriteLine("Press Enter when you're ready...");
            Console.ReadLine();

            while (low <= high)
            {
                int guess = GenerateGuess(low, high);

                Console.WriteLine($"My Guess: {guess}");
                Console.Write("Enter H (High), L (Low), C (Correct): ");

                char feedback = GetFeedback();

                if (feedback == 'C')
                {
                    Console.WriteLine("Yay! I guessed your number.");
                    break;
                }
                else if (feedback == 'H')
                {
                    high = guess - 1;
                }
                else if (feedback == 'L')
                {
                    low = guess + 1;
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }
        }

        static int GenerateGuess(int low, int high)
        {
            return (low + high) / 2;
        }

        static char GetFeedback()
        {
            return Convert.ToChar(Console.ReadLine().ToUpper());
        }
    }
}
