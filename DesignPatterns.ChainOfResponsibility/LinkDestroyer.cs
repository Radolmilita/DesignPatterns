using DesignPatterns.ChainOfResponsibility.Abstracts;

namespace DesignPatterns.ChainOfResponsibility;

public class LinkDestroyer : AbstractHandler
{
    public override void Handle(string request)
    {
        Console.WriteLine($"LinkDestroyer: Destroying the link {request}.");
        base.Handle(request);
    }
}