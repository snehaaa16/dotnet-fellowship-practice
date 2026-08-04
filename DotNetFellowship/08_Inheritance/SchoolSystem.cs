using System;

namespace _08_Inheritance
{
    internal class SchoolSystem
    {
        public string Name;
        public int Age;

        public SchoolSystem(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public virtual void DisplayRole()
        {
            Console.WriteLine("Person");
        }
    }

    internal class Teacher : SchoolSystem
    {
        public string Subject;

        public Teacher(string Name, int Age, string Subject)
            : base(Name, Age)
        {
            this.Subject = Subject;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Role : Teacher");
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Subject : " + Subject);
        }
    }

    internal class Student : SchoolSystem
    {
        public string Grade;

        public Student(string Name, int Age, string Grade)
            : base(Name, Age)
        {
            this.Grade = Grade;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Role : Student");
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Grade : " + Grade);
        }
    }

    internal class Staff : SchoolSystem
    {
        public string Department;

        public Staff(string Name, int Age, string Department)
            : base(Name, Age)
        {
            this.Department = Department;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Role : Staff");
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Department : " + Department);
        }
    }
}