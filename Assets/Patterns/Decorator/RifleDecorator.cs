abstract public class RifleDecorator : IRifle
{
    protected IRifle m_DecoaratedRifle;

    public RifleDecorator(IRifle rifle)
    {
        m_DecoaratedRifle = rifle;
    }

    public virtual float GetAccuracy()
    {
        return m_DecoaratedRifle.GetAccuracy();
    }
}
