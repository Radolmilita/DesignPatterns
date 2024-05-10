using DesignPatterns.Facade.Actions;

namespace DesignPatterns.Facade;

public class BilliardsFacade
{
    private CueStick cueStick = new();
    private BilliardTable table = new();
    private Balls balls = new();

    public void StartGame()
    {
        table.SetUpTable();
        balls.Roll();
    }

    public void HitBall()
    {
        cueStick.HitBall();
    }
}