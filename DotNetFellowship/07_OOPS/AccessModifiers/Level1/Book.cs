using System;

namespace _07_OOPS.AccessModifiers
{
    internal class Book
    {
        // Public Variable
        public string ISBN;

        // Protected Variable
        protected string title;

        // Private Variable
        private string author;

        // Constructor
        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;
            this.title = title;
            this.author = author;
        }

        // Setter
        public void SetAuthor(string author)
        {
            this.author = author;
        }

        // Getter
        public string GetAuthor()
        {
            return author;
        }

        public void DisplayBook()
        {
            Console.WriteLine("Book Details");
            Console.WriteLine($"ISBN   : {ISBN}");
            Console.WriteLine($"Title  : {title}");
            Console.WriteLine($"Author : {author}");
            Console.WriteLine();
        }
    }
}