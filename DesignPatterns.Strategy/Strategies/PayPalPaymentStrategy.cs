using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Strategies;

public class PayPalPaymentStrategy : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount} using PayPal.");
    }
}