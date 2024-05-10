using DesignPatterns.FactoryMethod.Interfaces;

namespace DesignPatterns.FactoryMethod.PaymentMethods;

public class ApplePayPayments : IPayment
{
    public string Pay()
    {
        return "Payed using ApplePay method";
    }
}