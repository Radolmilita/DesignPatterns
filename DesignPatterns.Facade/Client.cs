namespace DesignPatterns.Facade;

public static class Client
{
    public static void Execute()
    {
        var billiards = new BilliardsFacade();

        Console.WriteLine("Welcome to the Billiards Game!");

        while (true)
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Hit Ball");
            Console.WriteLine("3. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    billiards.StartGame();
                    break;
                case 2:
                    billiards.HitBall();
                    break;
                case 3:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}