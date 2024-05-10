using DesignPatterns.ChainOfResponsibility.Validators;

namespace DesignPatterns.ChainOfResponsibility;

public class Program
{
    static void Main(string[] args)
    {
        // Setting up the chain of responsibility
        var linkValidator = new LinkValidator();
        var linkDestroyer = new LinkDestroyer();
        linkValidator.SetNext(linkDestroyer);

        // Making requests
        linkValidator.Handle("https://www.microsoft.com");
        linkValidator.Handle("invalid link");

        Console.ReadKey();
    }
}