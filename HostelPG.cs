using System;
using System.Collections.Generic;


class HostelPG
{
    public string HostelName { get; set; } = "Green View PG";
    public List<Guest> Guests { get; set; } = new List<Guest>();

    public void AddGuest(Guest guest)
    {
        Guests.Add(guest);
        Console.WriteLine($"Guest {guest.Name} added to {HostelName}");
    }

    public void RemoveGuest(int guestId)
    {
        var guest = Guests.Find(g => g.GuestId == guestId);
        if (guest != null)
        {
            Guests.Remove(guest);
            Console.WriteLine($"Guest {guest.Name} removed.");
        }
        else
        {
            Console.WriteLine("Guest not found.");
        }
    }

    public void ShowAllGuests()
    {
        Console.WriteLine($"\nGuests in {HostelName}:");
        if (Guests.Count == 0)
        {
            Console.WriteLine("No guests found.");
        }
        else
        {
            foreach (var guest in Guests)
            {
                Console.WriteLine($"{guest.GuestId} - {guest.Name}, Room {guest.RoomNumber}, Phone: {guest.Phone}");
            }
        }
    }
}