using System;

class TicketNode
{
    public int TicketId;
    public string CustomerName;
    public string MovieName;
    public int SeatNumber;
    public string BookingTime;

    public TicketNode Next;

    public TicketNode(
        int ticketId,
        string customerName,
        string movieName,
        int seatNumber,
        string bookingTime)
    {
        TicketId = ticketId;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = bookingTime;
    }
}

class TicketReservationSystem
{
    TicketNode head;
    TicketNode tail;

    public void AddTicket(
        int ticketId,
        string customerName,
        string movieName,
        int seatNumber,
        string bookingTime)
    {
        TicketNode newNode =
            new TicketNode(
                ticketId,
                customerName,
                movieName,
                seatNumber,
                bookingTime);

        if (head == null)
        {
            head = tail = newNode;
            newNode.Next = head;
            return;
        }

        tail.Next = newNode;
        tail = newNode;
        tail.Next = head;
    }

    public void RemoveTicket(int ticketId)
    {
        if (head == null)
            return;

        TicketNode current = head;
        TicketNode previous = tail;

        do
        {
            if (current.TicketId == ticketId)
            {
                if (current == head)
                    head = head.Next;

                if (current == tail)
                    tail = previous;

                previous.Next = current.Next;

                if (tail != null)
                    tail.Next = head;

                return;
            }

            previous = current;
            current = current.Next;

        } while (current != head);

        Console.WriteLine("Ticket not found");
    }

    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked");
            return;
        }

        TicketNode current = head;

        do
        {
            Console.WriteLine(
                $"Ticket ID: {current.TicketId}, " +
                $"Customer: {current.CustomerName}, " +
                $"Movie: {current.MovieName}, " +
                $"Seat: {current.SeatNumber}, " +
                $"Time: {current.BookingTime}"
            );

            current = current.Next;

        } while (current != head);
    }

    public void SearchByCustomer(string customerName)
    {
        if (head == null)
            return;

        TicketNode current = head;

        do
        {
            if (current.CustomerName == customerName)
            {
                Console.WriteLine(
                    $"Ticket {current.TicketId}: {current.MovieName}, Seat {current.SeatNumber}"
                );
            }

            current = current.Next;

        } while (current != head);
    }

    public void SearchByMovie(string movieName)
    {
        if (head == null)
            return;

        TicketNode current = head;

        do
        {
            if (current.MovieName == movieName)
            {
                Console.WriteLine(
                    $"Ticket {current.TicketId}: {current.CustomerName}, Seat {current.SeatNumber}"
                );
            }

            current = current.Next;

        } while (current != head);
    }

    public int CountTickets()
    {
        if (head == null)
            return 0;

        int count = 0;
        TicketNode current = head;

        do
        {
            count++;
            current = current.Next;

        } while (current != head);

        return count;
    }

    static void Main()
    {
        TicketReservationSystem system =
            new TicketReservationSystem();

        system.AddTicket(
            101,
            "Sneha",
            "Avengers",
            10,
            "10:30 AM");

        system.AddTicket(
            102,
            "Aman",
            "Avatar",
            11,
            "11:00 AM");

        system.AddTicket(
            103,
            "Riya",
            "Avengers",
            12,
            "11:30 AM");

        Console.WriteLine("All Tickets:");
        system.DisplayTickets();

        Console.WriteLine("\nSearch by Movie:");
        system.SearchByMovie("Avengers");

        Console.WriteLine(
            $"\nTotal Tickets: {system.CountTickets()}"
        );

        system.RemoveTicket(102);

        Console.WriteLine("\nAfter Removing Ticket 102:");
        system.DisplayTickets();
    }
}