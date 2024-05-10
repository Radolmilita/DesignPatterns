using DesignPatterns.Wrapper.Interfaces;

namespace DesignPatterns.Wrapper.Services;

public class ReservationService : IReservationService
{
    public string ReserveTable(int tableNumber, DateTime dateTime)
    {
        return $"Table {tableNumber} reserved for {dateTime}";
    }

    public string CancelReservation(int tableNumber, DateTime dateTime)
    {
        return $"Reservation for table {tableNumber} at {dateTime} canceled";
    }
}