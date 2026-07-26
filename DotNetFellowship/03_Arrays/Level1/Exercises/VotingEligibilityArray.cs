using System;

namespace _03_Arrays.Level1.Exercises
{
    internal class VotingEligibilityArray
    {
        public static void CheckVotingEligibility(int[] ages)
        {
            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] < 0)
                {
                    Console.WriteLine("Invalid Age");
                }
                else if (ages[i] >= 18)
                {
                    Console.WriteLine("The student with age " + ages[i] + " can vote.");
                }
                else
                {
                    Console.WriteLine("The student with age " + ages[i] + " cannot vote.");
                }
            }
        }
    }
}