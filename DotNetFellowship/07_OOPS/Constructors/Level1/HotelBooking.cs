using System;

namespace _07_OOPS.Constructors.Level1
{
    internal class HotelBooking
    {
        private string guestName;
        private string roomType;
        private int nights;

        // Default Constructor
        public HotelBooking()
        {
            guestName = "Guest";
            roomType = "Standard";
            nights = 1;
        }

        // Parameterized Constructor
        public HotelBooking(string guestName, string roomType, int nights)
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.nights = nights;
        }

        // Copy Constructor
        public HotelBooking(HotelBooking other)
        {
            guestName = other.guestName;
            roomType = other.roomType;
            nights = other.nights;
        }

        public void DisplayBooking()
        {
            Console.WriteLine($"Guest Name : {guestName}");
            Console.WriteLine($"Room Type  : {roomType}");
            Console.WriteLine($"Nights     : {nights}");
            Console.WriteLine();
        }
    }
}