using DesignPatterns.State.Context;
using DesignPatterns.State.States;

static void Main(string[] args)
{
    // Setting up the file context
    FileContext fileContext = new FileContext(new OpenFileState());

    // Processing file
    fileContext.Request();
    fileContext.Request();
    fileContext.Request();

    Console.ReadKey();
}