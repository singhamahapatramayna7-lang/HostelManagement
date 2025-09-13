using System;

class Program
{
    // 🔹 Global HostelPG instance (shared everywhere)
    static HostelPG hostelpg = new HostelPG();

    public static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("       Hostel Management System       ");
            Console.WriteLine("=====================================");
            Console.WriteLine("1. Add New Guest");
            Console.WriteLine("2. View Room Details");
            Console.WriteLine("3. Record Payment");
            Console.WriteLine("4. View All Guests");
            Console.WriteLine("5. Exit");
            Console.WriteLine("=====================================");
            Console.Write("Enter your choice (1-5): ");



            bool running = true;

            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    AddGuest();
                    break;
                case "2":
                    ViewRoomDetails();
                    break;
                case "3":
                    RecordPayment();
                    break;
                case "4":
                    hostelpg.ShowAllGuests();
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Exiting system. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please select a valid option (1-5).");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
        }
    }

    static void AddGuest()
    {
        Console.Clear();
        Console.WriteLine("--- Add New Guest ---");

        Console.Write("Enter Guest ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Guest Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter Room Number: ");
        string room = Console.ReadLine();

        Console.Write("Enter Contact Number: ");
        string contact = Console.ReadLine();

        Guest guest = new Guest
        {
            GuestId = id,
            Name = name,
            Age = age,
            RoomNumber = room,
            Phone = contact,
            CheckInDate = DateTime.Now
        };

        hostelpg.AddGuest(guest);

        Console.WriteLine($"\nGuest {guest.Name} added successfully to Room {guest.RoomNumber}!");
    }

    static void ViewRoomDetails()
    {
        Console.Clear();
        Console.WriteLine("--- View Room Details ---");
        Console.Write("Enter Room Number: ");
        string room = Console.ReadLine();

        var guest = hostelpg.Guests.Find(g => g.RoomNumber == room);

        if (guest != null)
        {
            Console.WriteLine($"\nRoom {room} Details:");
            Console.WriteLine($"Status: Occupied");
            Console.WriteLine($"Guest: {guest.Name}");
            Console.WriteLine($"Contact: {guest.Phone}");
            Console.WriteLine($"Check-In Date: {guest.CheckInDate}");
        }
        else
        {
            Console.WriteLine($"\nRoom {room} is currently Vacant.");
        }

    }

    static void RecordPayment()
    {
        Console.Clear();
        Console.WriteLine("--- Record Payment ---");
        Console.Write("Enter Guest ID: ");
        int id = int.Parse(Console.ReadLine());

        var guest = hostelpg.Guests.Find(g => g.GuestId == id);

        if (guest != null)
        {
            Console.Write("Enter Amount Paid: ");
            string amount = Console.ReadLine();

            // Placeholder: You can store payment records in a list/dictionary
            Console.WriteLine($"\nPayment of ${amount} recorded for {guest.Name}!");
        }
        else
        {
            Console.WriteLine("Guest not found!");
        }
    }

}