using System;

namespace _07_OOPS.Constructors.Level1
{
    internal class Book
    {
        private string title;
        private string author;
        private double price;

        // Default Constructor
        public Book()
        {
            title = "Unknown";
            author = "Unknown";
            price = 0;
        }

        // Parameterized Constructor
        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public void DisplayBook()
        {
            Console.WriteLine("Book Details");
            Console.WriteLine($"Title : {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price : {price}");
            Console.WriteLine();
        }
    }
}