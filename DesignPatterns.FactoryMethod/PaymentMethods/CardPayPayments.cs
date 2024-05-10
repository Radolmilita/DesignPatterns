using DesignPatterns.FactoryMethod.Interfaces;

namespace DesignPatterns.FactoryMethod.PaymentMethods;

public class CardPayPayments : IPayment
{
    public string Pay()
    {
        return "Payed using CardPay method";
    }
}