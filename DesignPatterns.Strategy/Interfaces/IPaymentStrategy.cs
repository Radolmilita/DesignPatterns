namespace DesignPatterns.Strategy.Interfaces;

public interface IPaymentStrategy
{
    void Pay(decimal amount);
}