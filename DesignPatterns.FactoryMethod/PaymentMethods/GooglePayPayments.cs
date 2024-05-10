using DesignPatterns.FactoryMethod.Interfaces;

namespace DesignPatterns.FactoryMethod.PaymentMethods;

public class GooglePayPayments : IPayment
{
    public string Pay()
    {
        return "Payed using GooglePay method";
    }
}