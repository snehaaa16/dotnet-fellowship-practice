using System;
namespace _02_ControlFlow.Level1.Exercises
{
    internal class RocketCountdownFor
    {
        public static void Countdown(int counter)
        {
            for (int i = counter; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Rocket Launched!");
        }
    }
}