using System;

namespace _08_Inheritance
{
    // Base Class
    internal class AnimalHierarchy
    {
        public string Name;
        public int Age;

        public AnimalHierarchy(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
        }
    }

    // Derived Class
    internal class Dog : AnimalHierarchy
    {
        public Dog(string Name, int Age) : base(Name, Age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    // Derived Class
    internal class Cat : AnimalHierarchy
    {
        public Cat(string Name, int Age) : base(Name, Age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    // Derived Class
    internal class Bird : AnimalHierarchy
    {
        public Bird(string Name, int Age) : base(Name, Age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bird chirps.");
        }
    }
}