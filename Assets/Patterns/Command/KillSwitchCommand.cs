class KillSwitchCommand : Command
{
    private RemoteControlDevice[] m_Devices;
    private static RemoteControlDevice receiver;

    public KillSwitchCommand(RemoteControlDevice[] devices) : base(receiver)
    {
        m_Devices = devices;
    }

    public override void Execute()
    {
        foreach (RemoteControlDevice device in m_Devices)
        {
            device.TurnOff();
        }
    }
}