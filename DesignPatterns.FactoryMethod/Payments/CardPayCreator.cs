using DesignPatterns.FactoryMethod.Abstractions;
using DesignPatterns.FactoryMethod.Interfaces;
using DesignPatterns.FactoryMethod.PaymentMethods;

namespace DesignPatterns.FactoryMethod.Payments;

public class CardPayCreator : Creator
{
    public override IPayment FactoryMethod()
    {
        Console.WriteLine("CardPayCreator worked");

        return new CardPayPayments();
    }
}