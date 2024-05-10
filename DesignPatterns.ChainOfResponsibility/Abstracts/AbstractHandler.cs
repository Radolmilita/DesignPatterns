using DesignPatterns.ChainOfResponsibility.Interfaces;

namespace DesignPatterns.ChainOfResponsibility.Abstracts;

public class AbstractHandler : IHandler
{
    private IHandler _nextHandler;

    public IHandler SetNext(IHandler handler)
    {
        this._nextHandler = handler;
        return handler;
    }

    public virtual void Handle(string request)
    {
        if (this._nextHandler != null)
        {
            _nextHandler.Handle(request);
        }
    }
}