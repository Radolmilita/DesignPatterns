using DesignPatterns.Proxy.Interfaces;

namespace DesignPatterns.Proxy;

public static class Client
{
    public static void Execute()
    {
        IBilliardsTable table = new BilliardsTableProxy();

        Console.WriteLine("Welcome to the Billiards Club!");

        while (true)
        {
            Console.WriteLine("Press 'h' to hit the ball, or 'q' to quit.");
            var key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.H)
            {
                table.HitBall();
            }
            else if (key == ConsoleKey.Q)
            {
                Console.WriteLine("Exiting...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Press 'h' to hit the ball, or 'q' to quit.");
            }
        }
    }
}