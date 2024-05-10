using DesignPatterns.State.Context;
using DesignPatterns.State.Interfaces;

namespace DesignPatterns.State.States;

public class ReadFileState : IState
{
    public void Handle(FileContext context)
    {
        Console.WriteLine("Reading file...");
        context.SetState(new CloseFileState());
    }
}