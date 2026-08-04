using System;

namespace _08_Inheritance
{
    interface IRefuelable
    {
        void Refuel();
    }

    internal class VehicleManagement
    {
        public int MaxSpeed;
        public string Model;

        public VehicleManagement(int MaxSpeed, string Model)
        {
            this.MaxSpeed = MaxSpeed;
            this.Model = Model;
        }
    }

    internal class ElectricVehicle : VehicleManagement
    {
        public ElectricVehicle(int MaxSpeed, string Model)
            : base(MaxSpeed, Model)
        {
        }

        public void Charge()
        {
            Console.WriteLine(Model + " is charging.");
        }
    }

    internal class PetrolVehicle : VehicleManagement, IRefuelable
    {
        public PetrolVehicle(int MaxSpeed, string Model)
            : base(MaxSpeed, Model)
        {
        }

        public void Refuel()
        {
            Console.WriteLine(Model + " is refueling.");
        }
    }
}