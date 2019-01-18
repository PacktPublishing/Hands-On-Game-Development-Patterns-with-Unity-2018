class TurnOffCommand : Command
{
    public TurnOffCommand(RemoteControlDevice receiver) : base(receiver)
    {
    }

    public override void Execute()
    {
        m_Receiver.TurnOff();
    }
}