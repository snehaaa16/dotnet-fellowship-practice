using System;

class BookNode
{
    public string Title;
    public string Author;
    public string Genre;
    public int BookId;
    public bool Available;

    public BookNode Previous;
    public BookNode Next;

    public BookNode(
        string title,
        string author,
        string genre,
        int id,
        bool available)
    {
        Title = title;
        Author = author;
        Genre = genre;
        BookId = id;
        Available = available;
    }
}

class LibraryManagementSystem
{
    BookNode head;
    BookNode tail;

    public void AddAtBeginning(
        string title,
        string author,
        string genre,
        int id,
        bool available)
    {
        BookNode newNode =
            new BookNode(title, author, genre, id, available);

        if (head == null)
        {
            head = tail = newNode;
            return;
        }

        newNode.Next = head;
        head.Previous = newNode;
        head = newNode;
    }

    public void AddAtEnd(
        string title,
        string author,
        string genre,
        int id,
        bool available)
    {
        BookNode newNode =
            new BookNode(title, author, genre, id, available);

        if (head == null)
        {
            head = tail = newNode;
            return;
        }

        tail.Next = newNode;
        newNode.Previous = tail;
        tail = newNode;
    }

    public void AddAtPosition(
        int position,
        string title,
        string author,
        string genre,
        int id,
        bool available)
    {
        if (position == 1)
        {
            AddAtBeginning(title, author, genre, id, available);
            return;
        }

        BookNode current = head;

        for (int i = 1; i < position - 1 && current != null; i++)
            current = current.Next;

        if (current == null)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        if (current == tail)
        {
            AddAtEnd(title, author, genre, id, available);
            return;
        }

        BookNode newNode =
            new BookNode(title, author, genre, id, available);

        newNode.Next = current.Next;
        newNode.Previous = current;

        current.Next.Previous = newNode;
        current.Next = newNode;
    }

    public void RemoveById(int id)
    {
        BookNode current = head;

        while (current != null)
        {
            if (current.BookId == id)
            {
                if (current == head)
                    head = current.Next;

                if (current == tail)
                    tail = current.Previous;

                if (current.Previous != null)
                    current.Previous.Next = current.Next;

                if (current.Next != null)
                    current.Next.Previous = current.Previous;

                return;
            }

            current = current.Next;
        }
    }

    public void SearchByTitle(string title)
    {
        BookNode current = head;

        while (current != null)
        {
            if (current.Title == title)
            {
                DisplayBook(current);
                return;
            }

            current = current.Next;
        }
    }

    public void SearchByAuthor(string author)
    {
        BookNode current = head;

        while (current != null)
        {
            if (current.Author == author)
                DisplayBook(current);

            current = current.Next;
        }
    }

    public void UpdateAvailability(int id, bool status)
    {
        BookNode current = head;

        while (current != null)
        {
            if (current.BookId == id)
            {
                current.Available = status;
                return;
            }

            current = current.Next;
        }
    }

    public void DisplayForward()
    {
        BookNode current = head;

        while (current != null)
        {
            DisplayBook(current);
            current = current.Next;
        }
    }

    public void DisplayReverse()
    {
        BookNode current = tail;

        while (current != null)
        {
            DisplayBook(current);
            current = current.Previous;
        }
    }

    public int Count()
    {
        int count = 0;
        BookNode current = head;

        while (current != null)
        {
            count++;
            current = current.Next;
        }

        return count;
    }

    private void DisplayBook(BookNode book)
    {
        Console.WriteLine(
            $"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.Available}"
        );
    }

    static void Main()
    {
        LibraryManagementSystem library =
            new LibraryManagementSystem();

        library.AddAtBeginning(
            "C# Basics", "John", "Programming", 1, true);

        library.AddAtEnd(
            "DSA", "Mark", "Computer Science", 2, true);

        library.AddAtPosition(
            2, "OOP", "David", "Programming", 3, false);

        Console.WriteLine("Books:");
        library.DisplayForward();

        Console.WriteLine($"\nTotal Books: {library.Count()}");

        library.UpdateAvailability(3, true);
        library.RemoveById(1);

        Console.WriteLine("\nAfter Changes:");
        library.DisplayForward();
    }
}