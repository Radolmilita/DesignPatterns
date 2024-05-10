using DesignPatterns.Builder.Entities;
using DesignPatterns.Builder.Interfaces;

namespace DesignPatterns.Builder.Builders;

public class BilliardsTableBuilder : IBuilder
{ 
    private BilliardsTable  table = new();

    public void SetType(string type)
    {
        table.Type = type;
    }

    public void SetColor(string color)
    {
        table.Color = color;
    }

    public void SetNumberOfBalls(int numberOfBalls)
    {
        table.NumberOfBalls = numberOfBalls;
    }

    public BilliardsTable GetResult()
    {
        return table;
    }
}