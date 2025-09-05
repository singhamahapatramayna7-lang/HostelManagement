using System;

class Program
{
public static void Main(String[] args)
{




            bool running = true;

            while (running)
            {
                Console.Clear(); // Clear the console for a clean UI
                Console.WriteLine("=====================================");
                Console.WriteLine("       Hostel Management System       ");
                Console.WriteLine("=====================================");
                Console.WriteLine("1. Add New Student");
                Console.WriteLine("2. View Room Details");
                Console.WriteLine("3. Record Payment");
                Console.WriteLine("4. View All Students");
                Console.WriteLine("5. Exit");
                Console.WriteLine("=====================================");
                Console.Write("Enter your choice (1-5): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewStudent();
                        break;
                    case "2":
                        ViewRoomDetails();
                        break;
                    case "3":
                        RecordPayment();
                        break;
                    case "4":
                        ViewAllStudents();
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

        static void AddNewStudent()
        {
            Console.Clear();
            Console.WriteLine("--- Add New Student ---");
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Room Number: ");
            string room = Console.ReadLine();
            Console.Write("Enter Contact Number: ");
            string contact = Console.ReadLine();

            // Here, you can add logic to save the student to a database or list
            Console.WriteLine($"\nStudent {name} added successfully to Room {room}!");
        }

        static void ViewRoomDetails()
        {
            Console.Clear();
            Console.WriteLine("--- View Room Details ---");
            Console.Write("Enter Room Number: ");
            string room = Console.ReadLine();

            // Placeholder for room details logic (e.g., fetch from database)
            Console.WriteLine($"\nRoom {room} Details:");
            Console.WriteLine("Status: Occupied");
            Console.WriteLine("Student: John Doe");
            Console.WriteLine("Monthly Rent: $200");
        }

        static void RecordPayment()
        {
            Console.Clear();
            Console.WriteLine("--- Record Payment ---");
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Amount Paid: ");
            string amount = Console.ReadLine();

            // Placeholder for payment recording logic
            Console.WriteLine($"\nPayment of ${amount} recorded for {name}!");
        }

        static void ViewAllStudents()
        {
            Console.Clear();
            Console.WriteLine("--- All Students ---");
            // Placeholder for fetching student list
            Console.WriteLine("1. John Doe - Room 101");
            Console.WriteLine("2. Jane Smith - Room 102");
            Console.WriteLine("3. Alex Johnson - Room 103");
        }
    }
