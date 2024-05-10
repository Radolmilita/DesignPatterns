using DesignPatterns.Prototype.Entities;
using DesignPatterns.Prototype.Interfaces;

namespace DesignPatterns.Prototype;

public class Client
{
    public void Execute()
    {
        Console.WriteLine("Welcome to the Billiards Club!");
        Console.WriteLine("Choose a table type:");
        Console.WriteLine("1. Pyramid");
        Console.WriteLine("2. Snooker");
        Console.WriteLine("3. Pool");

        string input = Console.ReadLine();

        IBilliardsTable prototypeTable = null;

        switch (input)
        {
            case "1":
                prototypeTable = new BilliardsTable("Pyramid", "Green");
                break;
            case "2":
                prototypeTable = new BilliardsTable("Snooker", "Blue");
                break;
            case "3":
                prototypeTable = new BilliardsTable("Pool", "Red");
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting.");
                return;
        }

        // Clone the prototype to create a new table
        var table = (BilliardsTable)prototypeTable.Clone();
        table.SetupTable();

        Console.WriteLine("Enjoy your game!");
    }
}