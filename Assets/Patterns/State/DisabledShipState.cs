public class DisabledShipState : IShipState
{
    public void Execute(Ship ship)
    {
        ship.LogStatus("DISABLED: crew jumping ship.");
    }
}
