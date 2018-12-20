public class OperationalShipState : IShipState
{
    public void Execute(Ship ship)
    {
        ship.LogStatus("OPERATIONAL: everything operating as usual.");
    }
}
