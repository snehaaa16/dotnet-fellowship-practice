using System;

namespace _03_Arrays.Level1.Exercises
{
    internal class FizzBuzzArray
    {
        public static string[] GenerateFizzBuzz(int number)
        {
            string[] result = new string[number + 1];

            for (int i = 0; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result[i] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    result[i] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    result[i] = "Buzz";
                }
                else
                {
                    result[i] = i.ToString();
                }
            }

            return result;
        }
    }
}