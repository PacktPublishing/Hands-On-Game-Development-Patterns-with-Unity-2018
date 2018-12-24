public class OperationalShipState : IShipState
{
    public void Execute(Ship ship)
    {
        ship.LogStatus("OPERATIONAL: ship operating as normal.");
    }
}
