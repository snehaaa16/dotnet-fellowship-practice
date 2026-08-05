using System;

namespace _09_AbstractClass_Interface
{
    interface IDiscountable
    {
        double ApplyDiscount();
        void GetDiscountDetails();
    }

    internal abstract class OnlineFoodDeliverySystem
    {
        private string itemName;
        private double price;
        private int quantity;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public OnlineFoodDeliverySystem(string itemName, double price, int quantity)
        {
            ItemName = itemName;
            Price = price;
            Quantity = quantity;
        }

        public abstract double CalculateTotalPrice();

        public void GetItemDetails()
        {
            Console.WriteLine("Item : " + ItemName);
            Console.WriteLine("Price : " + Price);
            Console.WriteLine("Quantity : " + Quantity);
        }
    }

    internal class VegItem : OnlineFoodDeliverySystem, IDiscountable
    {
        public VegItem(string itemName, double price, int quantity)
            : base(itemName, price, quantity)
        {
        }

        public override double CalculateTotalPrice()
        {
            return Price * Quantity;
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * 0.10;
        }

        public void GetDiscountDetails()
        {
            Console.WriteLine("Discount : " + ApplyDiscount());
        }
    }

    internal class NonVegItem : OnlineFoodDeliverySystem, IDiscountable
    {
        public NonVegItem(string itemName, double price, int quantity)
            : base(itemName, price, quantity)
        {
        }

        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) + 100;
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * 0.05;
        }

        public void GetDiscountDetails()
        {
            Console.WriteLine("Discount : " + ApplyDiscount());
        }
    }
}