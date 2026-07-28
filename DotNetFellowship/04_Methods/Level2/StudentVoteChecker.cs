using System;

namespace _04_Methods.Level2
{
    public class StudentVoteChecker
    {
        public static bool CanStudentVote(int age)
        {
            if (age < 0)
                return false;

            return age >= 18;
        }
    }
}