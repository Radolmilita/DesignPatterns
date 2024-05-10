using DesignPatterns.FactoryMethod.Abstractions;
using DesignPatterns.FactoryMethod.Interfaces;
using FactoryMethod.PaymentMethods;

namespace DesignPatterns.FactoryMethod.Payments;

public class PrivatPayCreator : Creator
{
     public override IPayment FactoryMethod()
     {
          Console.WriteLine("PrivatPayCreator worked");

          return new PrivatPayments();
     }
}