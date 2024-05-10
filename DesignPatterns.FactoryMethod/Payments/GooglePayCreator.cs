using DesignPatterns.FactoryMethod.Abstractions;
using DesignPatterns.FactoryMethod.Interfaces;
using DesignPatterns.FactoryMethod.PaymentMethods;

namespace DesignPatterns.FactoryMethod.Payments;

public class GooglePayCreator : Creator
{
    public override IPayment FactoryMethod()
    {
        Console.WriteLine("GooglePayCreator worked");

        return new GooglePayPayments();
    }
}