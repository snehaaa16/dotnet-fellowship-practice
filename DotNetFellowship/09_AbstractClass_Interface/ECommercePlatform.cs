using System;

namespace _09_AbstractClass_Interface
{
    interface ITaxable
    {
        double CalculateTax();
        void GetTaxDetails();
    }

    internal abstract class ECommercePlatform
    {
        private int productId;
        private string name;
        private double price;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public ECommercePlatform(int productId, string name, double price)
        {
            ProductId = productId;
            Name = name;
            Price = price;
        }

        public abstract double CalculateDiscount();

        public void DisplayDetails()
        {
            Console.WriteLine("Product Id : " + ProductId);
            Console.WriteLine("Product Name : " + Name);
            Console.WriteLine("Price : " + Price);
        }
    }

    internal class Electronics : ECommercePlatform, ITaxable
    {
        public Electronics(int productId, string name, double price)
            : base(productId, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.10;
        }

        public double CalculateTax()
        {
            return Price * 0.18;
        }

        public void GetTaxDetails()
        {
            Console.WriteLine("Tax : " + CalculateTax());
        }
    }

    internal class Clothing : ECommercePlatform, ITaxable
    {
        public Clothing(int productId, string name, double price)
            : base(productId, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.20;
        }

        public double CalculateTax()
        {
            return Price * 0.05;
        }

        public void GetTaxDetails()
        {
            Console.WriteLine("Tax : " + CalculateTax());
        }
    }

    internal class Groceries : ECommercePlatform
    {
        public Groceries(int productId, string name, double price)
            : base(productId, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.05;
        }
    }
}