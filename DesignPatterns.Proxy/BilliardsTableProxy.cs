using DesignPatterns.Proxy.Entities;
using DesignPatterns.Proxy.Interfaces;

namespace DesignPatterns.Proxy;

public class BilliardsTableProxy : IBilliardsTable
{
    private BilliardsTable _billiardsTable;
    
    public void HitBall()
    {
        if (_billiardsTable == null)
        {
            _billiardsTable = new BilliardsTable();
        }
        
        Console.WriteLine("Proxy: Checking access before hitting the ball.");

        _billiardsTable.HitBall();
        
        Console.WriteLine("Proxy: Logging after hitting the ball.");
    }
}