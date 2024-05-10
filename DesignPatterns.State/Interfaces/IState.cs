using DesignPatterns.State.Context;

namespace DesignPatterns.State.Interfaces;

public interface IState
{
    void Handle(FileContext context);
}