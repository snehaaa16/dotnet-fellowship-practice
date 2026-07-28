using System;

namespace _04_Methods.Level1
{
    public class MaximumHandshakes
    {
        public static int CalculateHandshakes(int numberOfStudents)
        {
            return (numberOfStudents * (numberOfStudents - 1)) / 2;
        }
    }
}