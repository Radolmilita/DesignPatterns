namespace DesignPatterns.Wrapper.Interfaces;

public interface IReservationService
{
    string ReserveTable(int tableNumber, DateTime dateTime);
    string CancelReservation(int tableNumber, DateTime dateTime);
}