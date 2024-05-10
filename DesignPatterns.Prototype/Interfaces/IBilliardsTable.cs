namespace DesignPatterns.Prototype.Interfaces;

public interface IBilliardsTable
{
    void SetupTable();
    IBilliardsTable Clone();
}