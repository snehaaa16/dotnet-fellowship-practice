using System;
namespace _02_ControlFlow.Level1.Exercises
{
    internal class RocketCountdownWhile
    {
        public static void Countdown(int counter)
        {
            while (counter >= 1)
            {
                Console.WriteLine(counter);
                counter--;
            }
            Console.WriteLine("Rocket Launched!");
        }
    }
}