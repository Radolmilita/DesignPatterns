using DesignPatterns.FactoryMethod.Abstractions;
using DesignPatterns.FactoryMethod.Interfaces;
using DesignPatterns.FactoryMethod.PaymentMethods;

namespace DesignPatterns.FactoryMethod.Payments;

public class ApplePayCreator : Creator
{
    public override IPayment FactoryMethod()
    {
        Console.WriteLine("ApplePay Creator worked");
        
        return new ApplePayPayments();
    }
}