using DesignPatterns.Builder.Entities;

namespace DesignPatterns.Builder.Interfaces;

public interface IBuilder
{
    void SetType(string type);
    void SetColor(string color);
    void SetNumberOfBalls(int numberOfBalls);
    BilliardsTable GetResult();
}