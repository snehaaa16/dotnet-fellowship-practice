using System;
using System.Collections.Generic;
using System.Text;

namespace _07_OOPS.Static_This_Readonly_IsOperator
{
    internal class LibraryManagementSystem
    {
        // Static Variable
        public static string LibraryName = "Central Library";

        // Instance Variables
        public string Title;
        public string Author;

        // Readonly Variable
        public readonly string ISBN;

        // Constructor
        public LibraryManagementSystem(string Title, string Author, string ISBN)
        {
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
        }

        // Static Method
        public static void DisplayLibraryName()
        {
            Console.WriteLine("Library Name : " + LibraryName);
        }

        // Instance Method
        public void DisplayDetails()
        {
            Console.WriteLine("Title : " + Title);
            Console.WriteLine("Author : " + Author);
            Console.WriteLine("ISBN : " + ISBN);
        }
    }
}
