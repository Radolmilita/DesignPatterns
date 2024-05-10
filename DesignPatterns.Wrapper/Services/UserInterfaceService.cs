using DesignPatterns.Wrapper.Interfaces;

namespace DesignPatterns.Wrapper.Services;

public class UserInterfaceService : IUserInterface
{
    private IReservationService _reservationService = new ReservationService();

    public string ReserveTable()
    {
        Console.Write("Enter table number: ");
        int tableNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter reservation date and time (yyyy-MM-dd HH:mm): ");
        DateTime dateTime = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", null);

        return _reservationService.ReserveTable(tableNumber, dateTime);
    }

    public string CancelReservation()
    {
        Console.Write("Enter table number: ");
        int tableNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter reservation date and time (yyyy-MM-dd HH:mm): ");
        DateTime dateTime = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", null);

        return _reservationService.CancelReservation(tableNumber, dateTime);
    }
}