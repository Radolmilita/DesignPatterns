using DesignPatterns.Strategy.Context;
using DesignPatterns.Strategy.Interfaces;
using DesignPatterns.Strategy.Strategies;

class Program
{
    static void Main(string[] args)
    {
        // Setting up the strategy
        IPaymentStrategy paymentMethod = new CreditCardPaymentStrategy();
        PaymentContext paymentContext = new PaymentContext(paymentMethod);

        // Making payment
        paymentContext.ExecutePayment(150.00m);

        // Changing the strategy
        paymentMethod = new PayPalPaymentStrategy();
        paymentContext = new PaymentContext(paymentMethod);

        // Making payment
        paymentContext.ExecutePayment(250.00m);
    }
};