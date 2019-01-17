abstract class Command
{
    protected Receiver m_Receiver;

    public Command(Receiver receiver)
    {
        m_Receiver = receiver;
    }

    public abstract void Execute();
}