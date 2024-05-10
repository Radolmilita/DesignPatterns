using DesignPatterns.ChainOfResponsibility.Abstracts;

namespace DesignPatterns.ChainOfResponsibility.Validators;

public class LinkValidator : AbstractHandler
{
    public override void Handle(string request)
    {
        if (Uri.IsWellFormedUriString(request, UriKind.Absolute))
        {
            Console.WriteLine("LinkValidator: Link is valid.");
            base.Handle(request);
        }
        else
        {
            Console.WriteLine("LinkValidator: Invalid link.");
        }
    }
}