using System;

namespace _09_AbstractClass_Interface
{
    interface IReservable
    {
        void ReserveItem();
        void CheckAvailability();
    }

    internal abstract class LibraryManagementSystem
    {
        private int itemId;
        private string title;
        private string author;
        private string borrowerName;

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        protected string BorrowerName
        {
            get { return borrowerName; }
            set { borrowerName = value; }
        }

        public LibraryManagementSystem(int itemId, string title, string author)
        {
            ItemId = itemId;
            Title = title;
            Author = author;
        }

        public abstract int GetLoanDuration();

        public void GetItemDetails()
        {
            Console.WriteLine("Item Id : " + ItemId);
            Console.WriteLine("Title : " + Title);
            Console.WriteLine("Author : " + Author);
        }
    }

    internal class Book : LibraryManagementSystem, IReservable
    {
        public Book(int itemId, string title, string author)
            : base(itemId, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 15;
        }

        public void ReserveItem()
        {
            Console.WriteLine("Book Reserved");
        }

        public void CheckAvailability()
        {
            Console.WriteLine("Book Available");
        }
    }

    internal class Magazine : LibraryManagementSystem, IReservable
    {
        public Magazine(int itemId, string title, string author)
            : base(itemId, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 7;
        }

        public void ReserveItem()
        {
            Console.WriteLine("Magazine Reserved");
        }

        public void CheckAvailability()
        {
            Console.WriteLine("Magazine Available");
        }
    }

    internal class DVD : LibraryManagementSystem, IReservable
    {
        public DVD(int itemId, string title, string author)
            : base(itemId, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 3;
        }

        public void ReserveItem()
        {
            Console.WriteLine("DVD Reserved");
        }

        public void CheckAvailability()
        {
            Console.WriteLine("DVD Available");
        }
    }
}