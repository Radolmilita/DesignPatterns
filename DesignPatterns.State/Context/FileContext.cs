using DesignPatterns.State.Interfaces;

namespace DesignPatterns.State.Context;

public class FileContext
{
    private IState _state;

    public FileContext(IState state)
    {
        _state = state;
    }

    public void SetState(IState state)
    {
        _state = state;
    }

    public void Request()
    {
        _state.Handle(this);
    }
}