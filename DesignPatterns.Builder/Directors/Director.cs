using DesignPatterns.Builder.Interfaces;

namespace DesignPatterns.Builder.Directors;

public class Director
{
    private IBuilder builder;

    public Director(IBuilder builder)
    {
        this.builder = builder;
    }

    public void ConstructTable()
    {
        builder.SetType("Pool");
        builder.SetColor("Blue");
        builder.SetNumberOfBalls(9);
    }
}