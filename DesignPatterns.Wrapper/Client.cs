using DesignPatterns.Wrapper.Services;

namespace DesignPatterns.Wrapper;

public static class Client
{
    public static void Execute()
    {
        var ui = new UserInterfaceService();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Reserve table");
            Console.WriteLine("2. Cancel reservation");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine(ui.ReserveTable());
                    break;
                case 2:
                    Console.WriteLine(ui.CancelReservation());
                    break;
                case 3:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}