using System;

namespace _08_Inheritance
{
    internal class OnlineRetailOrderManagement
    {
        public int OrderId;
        public string OrderDate;

        public OnlineRetailOrderManagement(int OrderId, string OrderDate)
        {
            this.OrderId = OrderId;
            this.OrderDate = OrderDate;
        }

        public virtual void GetOrderStatus()
        {
            Console.WriteLine("Order Placed");
        }
    }

    internal class ShippedOrder : OnlineRetailOrderManagement
    {
        public string TrackingNumber;

        public ShippedOrder(int OrderId, string OrderDate, string TrackingNumber)
            : base(OrderId, OrderDate)
        {
            this.TrackingNumber = TrackingNumber;
        }

        public override void GetOrderStatus()
        {
            Console.WriteLine("Order Shipped");
        }
    }

    internal class DeliveredOrder : ShippedOrder
    {
        public string DeliveryDate;

        public DeliveredOrder(int OrderId, string OrderDate, string TrackingNumber, string DeliveryDate)
            : base(OrderId, OrderDate, TrackingNumber)
        {
            this.DeliveryDate = DeliveryDate;
        }

        public override void GetOrderStatus()
        {
            Console.WriteLine("Order Delivered");
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Order Id : " + OrderId);
            Console.WriteLine("Order Date : " + OrderDate);
            Console.WriteLine("Tracking Number : " + TrackingNumber);
            Console.WriteLine("Delivery Date : " + DeliveryDate);
        }
    }
}