using System;

class MovieNode
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;

    public MovieNode Previous;
    public MovieNode Next;

    public MovieNode(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
    }
}

class MovieManagementSystem
{
    MovieNode head;
    MovieNode tail;

    public void AddAtBeginning(string title, string director, int year, double rating)
    {
        MovieNode newNode = new MovieNode(title, director, year, rating);

        if (head == null)
        {
            head = tail = newNode;
            return;
        }

        newNode.Next = head;
        head.Previous = newNode;
        head = newNode;
    }

    public void AddAtEnd(string title, string director, int year, double rating)
    {
        MovieNode newNode = new MovieNode(title, director, year, rating);

        if (head == null)
        {
            head = tail = newNode;
            return;
        }

        tail.Next = newNode;
        newNode.Previous = tail;
        tail = newNode;
    }

    public void AddAtPosition(int position, string title, string director, int year, double rating)
    {
        if (position == 1)
        {
            AddAtBeginning(title, director, year, rating);
            return;
        }

        MovieNode current = head;

        for (int i = 1; i < position - 1 && current != null; i++)
        {
            current = current.Next;
        }

        if (current == null)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        if (current == tail)
        {
            AddAtEnd(title, director, year, rating);
            return;
        }

        MovieNode newNode = new MovieNode(title, director, year, rating);

        newNode.Next = current.Next;
        newNode.Previous = current;

        current.Next.Previous = newNode;
        current.Next = newNode;
    }

    public void RemoveByTitle(string title)
    {
        MovieNode current = head;

        while (current != null)
        {
            if (current.Title == title)
            {
                if (current == head)
                    head = current.Next;

                if (current == tail)
                    tail = current.Previous;

                if (current.Previous != null)
                    current.Previous.Next = current.Next;

                if (current.Next != null)
                    current.Next.Previous = current.Previous;

                Console.WriteLine("Movie removed");
                return;
            }

            current = current.Next;
        }

        Console.WriteLine("Movie not found");
    }

    public void SearchByDirector(string director)
    {
        MovieNode current = head;

        while (current != null)
        {
            if (current.Director == director)
            {
                Console.WriteLine(
                    $"{current.Title} - {current.Year} - Rating: {current.Rating}"
                );
            }

            current = current.Next;
        }
    }

    public void SearchByRating(double rating)
    {
        MovieNode current = head;

        while (current != null)
        {
            if (current.Rating == rating)
            {
                Console.WriteLine(current.Title);
            }

            current = current.Next;
        }
    }

    public void DisplayForward()
    {
        MovieNode current = head;

        while (current != null)
        {
            Console.WriteLine(
                $"{current.Title} | {current.Director} | {current.Year} | {current.Rating}"
            );

            current = current.Next;
        }
    }

    public void DisplayReverse()
    {
        MovieNode current = tail;

        while (current != null)
        {
            Console.WriteLine(
                $"{current.Title} | {current.Director} | {current.Year} | {current.Rating}"
            );

            current = current.Previous;
        }
    }

    public void UpdateRating(string title, double newRating)
    {
        MovieNode current = head;

        while (current != null)
        {
            if (current.Title == title)
            {
                current.Rating = newRating;
                Console.WriteLine("Rating updated");
                return;
            }

            current = current.Next;
        }
    }

    static void Main()
    {
        MovieManagementSystem movies = new MovieManagementSystem();

        movies.AddAtBeginning("Inception", "Nolan", 2010, 8.8);
        movies.AddAtEnd("Interstellar", "Nolan", 2014, 8.6);
        movies.AddAtPosition(2, "Avatar", "Cameron", 2009, 7.8);

        Console.WriteLine("Forward:");
        movies.DisplayForward();

        Console.WriteLine("\nReverse:");
        movies.DisplayReverse();

        movies.UpdateRating("Avatar", 8.0);

        movies.RemoveByTitle("Inception");

        Console.WriteLine("\nAfter Delete:");
        movies.DisplayForward();
    }
}