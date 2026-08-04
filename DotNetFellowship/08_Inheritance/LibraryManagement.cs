using System;

namespace _08_Inheritance
{
    internal class LibraryManagement
    {
        public string Title;
        public int PublicationYear;

        public LibraryManagement(string Title, int PublicationYear)
        {
            this.Title = Title;
            this.PublicationYear = PublicationYear;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Title : " + Title);
            Console.WriteLine("Publication Year : " + PublicationYear);
        }
    }

    internal class Author : LibraryManagement
    {
        public string Name;
        public string Bio;

        public Author(string Title, int PublicationYear, string Name, string Bio)
            : base(Title, PublicationYear)
        {
            this.Name = Name;
            this.Bio = Bio;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Author Name : " + Name);
            Console.WriteLine("Bio : " + Bio);
        }
    }
}