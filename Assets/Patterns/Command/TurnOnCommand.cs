class TurnOnCommand : Command
{
    public TurnOnCommand(RemoteControlDevice receiver) : base(receiver)
    {
    }

    public override void Execute()
    {
        m_Receiver.TurnOn();
    }
}