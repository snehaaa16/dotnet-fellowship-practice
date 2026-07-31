using System;

namespace _07_OOPS.Constructors.Level1
{
    internal class LibraryBook
    {
        private string title;
        private string author;
        private double price;
        private bool availability;

        // Default Constructor
        public LibraryBook()
        {
            title = "Unknown";
            author = "Unknown";
            price = 0;
            availability = true;
        }

        // Parameterized Constructor
        public LibraryBook(string title, string author, double price, bool availability)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.availability = availability;
        }

        public void BorrowBook()
        {
            if (availability)
            {
                availability = false;
                Console.WriteLine($"{title} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"{title} is not available.");
            }
        }

        public void DisplayBook()
        {
            Console.WriteLine("Library Book Details");
            Console.WriteLine($"Title        : {title}");
            Console.WriteLine($"Author       : {author}");
            Console.WriteLine($"Price        : {price}");
            Console.WriteLine($"Availability : {availability}");
            Console.WriteLine();
        }
    }
}