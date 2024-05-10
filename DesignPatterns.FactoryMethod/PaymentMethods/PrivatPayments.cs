using DesignPatterns.FactoryMethod.Interfaces;

namespace FactoryMethod.PaymentMethods;

public class PrivatPayments : IPayment
{
    public string Pay()
    {
        return "Payed using Privat payment method";
    }
}