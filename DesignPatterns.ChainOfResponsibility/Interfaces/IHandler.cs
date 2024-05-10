namespace DesignPatterns.ChainOfResponsibility.Interfaces;

public interface IHandler
{
    IHandler SetNext(IHandler handler);
    void Handle(string request);
}