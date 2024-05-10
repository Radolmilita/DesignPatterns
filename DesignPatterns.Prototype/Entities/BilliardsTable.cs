using DesignPatterns.Prototype.Interfaces;

namespace DesignPatterns.Prototype.Entities;

public class BilliardsTable : IBilliardsTable
{
    private string Type { get; set; }
    private string Color { get; set; }

    public BilliardsTable(string type, string color)
    {
        Type = type;
        Color = color;
    }

    public void SetupTable()
    {
        Console.WriteLine($"Setting up {Color} {Type} table");
    }

    public IBilliardsTable ShallowCopy()
    {
        return (BilliardsTable) this.MemberwiseClone();
    }
    
    public IBilliardsTable Clone()
    {
        var clone = (BilliardsTable)this.MemberwiseClone();
        clone.Color = String.Copy(Color);
        clone.Type = String.Copy(Type);
        return clone;
    }
}