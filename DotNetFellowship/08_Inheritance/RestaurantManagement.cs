using System;

namespace _08_Inheritance
{
    interface IWorker
    {
        void PerformDuties();
    }

    internal class RestaurantManagement
    {
        public string Name;
        public int Id;

        public RestaurantManagement(string Name, int Id)
        {
            this.Name = Name;
            this.Id = Id;
        }
    }

    internal class Chef : RestaurantManagement, IWorker
    {
        public Chef(string Name, int Id)
            : base(Name, Id)
        {
        }

        public void PerformDuties()
        {
            Console.WriteLine(Name + " prepares food.");
        }
    }

    internal class Waiter : RestaurantManagement, IWorker
    {
        public Waiter(string Name, int Id)
            : base(Name, Id)
        {
        }

        public void PerformDuties()
        {
            Console.WriteLine(Name + " serves customers.");
        }
    }
}