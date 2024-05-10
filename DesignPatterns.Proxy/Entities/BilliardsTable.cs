using DesignPatterns.Proxy.Interfaces;

namespace DesignPatterns.Proxy.Entities;

public class BilliardsTable : IBilliardsTable
{
    public void HitBall()
    {
        Console.WriteLine("Ball hit!");
    }
}