public class AlertShipState : IShipState
{
    public void Execute(Ship ship)
    {
        ship.LogStatus("ALERT: all hands on deck.");
    }
}
