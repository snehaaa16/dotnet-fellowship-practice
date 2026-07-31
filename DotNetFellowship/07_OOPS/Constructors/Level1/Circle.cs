using System;

namespace _07_OOPS.Constructors.Level1
{
    internal class Circle
    {
        private double radius;

        // Default Constructor
        public Circle() : this(1)
        {
        }

        // Parameterized Constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public void DisplayCircle()
        {
            Console.WriteLine($"Radius : {radius}");
            Console.WriteLine($"Area   : {CalculateArea():F2}");
            Console.WriteLine();
        }
    }
}