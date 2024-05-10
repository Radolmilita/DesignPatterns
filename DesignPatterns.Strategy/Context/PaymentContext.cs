using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Context;

public class PaymentContext
{
    private IPaymentStrategy _paymentStrategy;

    public PaymentContext(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void ExecutePayment(decimal amount)
    {
        _paymentStrategy.Pay(amount);
    }
}