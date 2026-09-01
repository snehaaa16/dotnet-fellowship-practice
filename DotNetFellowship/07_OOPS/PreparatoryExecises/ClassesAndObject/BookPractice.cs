using System;
using System.Collections.Generic;
using System.Text;

namespace _07_OOPS.PreparatoryExecises.ClassesAndObject
{
    internal class BookPractice
    {
        readonly string Title;
        readonly string Author;
        readonly int Price;

        public BookPractice(string title,string author,int price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public void ShowDetails()
        {
            Console.Write("Title is :"+ Title + " and Author is : "+ Author+"and price of book is  :"+ Price);
        }
    }
}
