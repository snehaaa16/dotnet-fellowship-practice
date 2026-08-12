using System;

class StudentNode
{
    public int RollNumber;
    public string Name;
    public int Age;
    public char Grade;
    public StudentNode Next;

    public StudentNode(int rollNumber, string name, int age, char grade)
    {
        RollNumber = rollNumber;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentRecordManagement
{
    StudentNode head;

    public void AddAtBeginning(int roll, string name, int age, char grade)
    {
        StudentNode newNode = new StudentNode(roll, name, age, grade);

        newNode.Next = head;
        head = newNode;
    }

    public void AddAtEnd(int roll, string name, int age, char grade)
    {
        StudentNode newNode = new StudentNode(roll, name, age, grade);

        if (head == null)
        {
            head = newNode;
            return;
        }

        StudentNode current = head;

        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;
    }

    public void AddAtPosition(int position, int roll, string name, int age, char grade)
    {
        if (position == 1)
        {
            AddAtBeginning(roll, name, age, grade);
            return;
        }

        StudentNode newNode = new StudentNode(roll, name, age, grade);
        StudentNode current = head;

        for (int i = 1; i < position - 1 && current != null; i++)
        {
            current = current.Next;
        }

        if (current == null)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        newNode.Next = current.Next;
        current.Next = newNode;
    }

    public void DeleteByRollNumber(int roll)
    {
        if (head == null)
            return;

        if (head.RollNumber == roll)
        {
            head = head.Next;
            return;
        }

        StudentNode current = head;

        while (current.Next != null)
        {
            if (current.Next.RollNumber == roll)
            {
                current.Next = current.Next.Next;
                return;
            }

            current = current.Next;
        }

        Console.WriteLine("Student not found");
    }

    public void SearchByRollNumber(int roll)
    {
        StudentNode current = head;

        while (current != null)
        {
            if (current.RollNumber == roll)
            {
                Console.WriteLine($"Roll: {current.RollNumber}");
                Console.WriteLine($"Name: {current.Name}");
                Console.WriteLine($"Age: {current.Age}");
                Console.WriteLine($"Grade: {current.Grade}");
                return;
            }

            current = current.Next;
        }

        Console.WriteLine("Student not found");
    }

    public void Display()
    {
        StudentNode current = head;

        while (current != null)
        {
            Console.WriteLine(
                $"Roll: {current.RollNumber}, Name: {current.Name}, Age: {current.Age}, Grade: {current.Grade}"
            );

            current = current.Next;
        }
    }

    public void UpdateGrade(int roll, char newGrade)
    {
        StudentNode current = head;

        while (current != null)
        {
            if (current.RollNumber == roll)
            {
                current.Grade = newGrade;
                Console.WriteLine("Grade updated");
                return;
            }

            current = current.Next;
        }

        Console.WriteLine("Student not found");
    }

    static void Main()
    {
        StudentRecordManagement list = new StudentRecordManagement();

        list.AddAtBeginning(101, "Sneha", 20, 'A');
        list.AddAtEnd(102, "Aman", 21, 'B');
        list.AddAtPosition(2, 103, "Riya", 20, 'A');

        Console.WriteLine("Students:");
        list.Display();

        Console.WriteLine("\nSearch:");
        list.SearchByRollNumber(102);

        list.UpdateGrade(102, 'A');

        Console.WriteLine("\nAfter Update:");
        list.Display();

        list.DeleteByRollNumber(101);

        Console.WriteLine("\nAfter Delete:");
        list.Display();
    }
}