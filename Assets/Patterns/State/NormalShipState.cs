public class NormalShipState : IShipState
{
    public void Execute(Ship ship)
    {
        ship.LogStatus("NORMAL: ship operating as normal.");
    }
}
