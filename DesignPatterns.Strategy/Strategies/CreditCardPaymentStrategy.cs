using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Strategies;

public class CreditCardPaymentStrategy : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount} using Credit Card.");
    }
}