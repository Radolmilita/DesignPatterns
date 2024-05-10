using DesignPatterns.FactoryMethod.Abstractions;
using DesignPatterns.FactoryMethod.PaymentMethods.Enums;
using DesignPatterns.FactoryMethod.Payments;

namespace DesignPatterns.FactoryMethod;

public class Client
{
    public void Execute()
    {
        Console.WriteLine("Please choose a payment method:");
        Console.WriteLine("1. Apple Pay");
        Console.WriteLine("2. Card Pay");
        Console.WriteLine("3. Google Pay");
        Console.WriteLine("4. Privat Pay");

        int userInput;
        while (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || userInput > 4)
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 4.");
        }

        var preferredMethod = (PaymentMethodsEnum)(userInput);

        Creator creator;

        switch (preferredMethod)
        {
            case PaymentMethodsEnum.APPLE:
                Console.WriteLine("App: Launched with the ApplePayCreator.");
                creator = new ApplePayCreator();
                break;
            case PaymentMethodsEnum.CARD:
                Console.WriteLine("App: Launched with the CardPayCreator.");
                creator = new CardPayCreator();
                break;
            case PaymentMethodsEnum.GOOGLE:
                Console.WriteLine("App: Launched with the GooglePayCreator.");
                creator = new GooglePayCreator();
                break;
            case PaymentMethodsEnum.PRIVAT:
                Console.WriteLine("App: Launched with the PrivatPayCreator.");
                creator = new PrivatPayCreator();
                break;
            default:
                throw new ArgumentException("Invalid payment method specified.");
        }

        Console.WriteLine("");

        Console.WriteLine("App: Launched with the chosen payment method.");
        ClientCode(creator);
        
    }

    public void ClientCode(Creator creator)
    {
        Console.WriteLine("Client not aware of the creator's class,\n" + creator.PayOperation());
    }
}