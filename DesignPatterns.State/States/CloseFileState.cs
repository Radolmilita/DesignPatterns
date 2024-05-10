using DesignPatterns.State.Context;
using DesignPatterns.State.Interfaces;

namespace DesignPatterns.State.States;

public class CloseFileState : IState
{
    public void Handle(FileContext context)
    {
        Console.WriteLine("Closing file...");
    }
}