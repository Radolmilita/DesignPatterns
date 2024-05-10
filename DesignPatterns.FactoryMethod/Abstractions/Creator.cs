using DesignPatterns.FactoryMethod.Interfaces;

namespace DesignPatterns.FactoryMethod.Abstractions;

public abstract class Creator
{
    public abstract IPayment FactoryMethod();
    
    public string PayOperation()
    {
        var pay = FactoryMethod();

        var result = "Creator's code worked with: " + pay.Pay();

        return result;
    }
}