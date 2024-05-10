namespace DesignPatterns.Builder.Entities;

public class BilliardsTable
{
    public string Type { get; set; }
    public string Color { get; set; }
    public int NumberOfBalls { get; set; }

    public string Display()
    {
        return $"Billiards Table: Type - {Type}, Color - {Color}, Number of Balls - {NumberOfBalls}";
    } 
}