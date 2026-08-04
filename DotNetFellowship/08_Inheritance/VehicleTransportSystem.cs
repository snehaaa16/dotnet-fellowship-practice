using System;

namespace _08_Inheritance
{
    internal class VehicleTransportSystem
    {
        public int MaxSpeed;
        public string FuelType;

        public VehicleTransportSystem(int MaxSpeed, string FuelType)
        {
            this.MaxSpeed = MaxSpeed;
            this.FuelType = FuelType;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Max Speed : " + MaxSpeed);
            Console.WriteLine("Fuel Type : " + FuelType);
        }
    }

    internal class Car : VehicleTransportSystem
    {
        public int SeatCapacity;

        public Car(int MaxSpeed, string FuelType, int SeatCapacity)
            : base(MaxSpeed, FuelType)
        {
            this.SeatCapacity = SeatCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Seat Capacity : " + SeatCapacity);
        }
    }

    internal class Truck : VehicleTransportSystem
    {
        public int PayloadCapacity;

        public Truck(int MaxSpeed, string FuelType, int PayloadCapacity)
            : base(MaxSpeed, FuelType)
        {
            this.PayloadCapacity = PayloadCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Payload Capacity : " + PayloadCapacity + " kg");
        }
    }

    internal class Motorcycle : VehicleTransportSystem
    {
        public bool HasSidecar;

        public Motorcycle(int MaxSpeed, string FuelType, bool HasSidecar)
            : base(MaxSpeed, FuelType)
        {
            this.HasSidecar = HasSidecar;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Has Sidecar : " + HasSidecar);
        }
    }
}