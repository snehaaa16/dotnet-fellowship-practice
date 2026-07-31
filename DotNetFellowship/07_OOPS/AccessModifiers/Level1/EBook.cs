using System;

namespace _07_OOPS.AccessModifiers
{
    internal class EBook : Book
    {
        public EBook(string isbn, string title, string author)
            : base(isbn, title, author)
        {
        }

        public void DisplayEBook()
        {
            Console.WriteLine("EBook Details");
            Console.WriteLine($"ISBN  : {ISBN}");
            Console.WriteLine($"Title : {title}");

            // author is private, so use getter
            Console.WriteLine($"Author: {GetAuthor()}");
            Console.WriteLine();
        }
    }
}