using DesignPatterns.State.Context;
using DesignPatterns.State.Interfaces;

namespace DesignPatterns.State.States;

public class OpenFileState : IState
{
    public void Handle(FileContext context)
    {
        Console.WriteLine("Opening file...");
        context.SetState(new ReadFileState());
    }
}