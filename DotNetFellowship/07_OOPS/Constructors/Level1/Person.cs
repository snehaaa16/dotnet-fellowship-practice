using System;

namespace _07_OOPS.Constructors.Level1
{
    internal class Person
    {
        private string name;
        private int age;

        // Parameterized Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Copy Constructor
        public Person(Person other)
        {
            this.name = other.name;
            this.age = other.age;
        }

        public void DisplayPerson()
        {
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age  : {age}");
            Console.WriteLine();
        }
    }
}