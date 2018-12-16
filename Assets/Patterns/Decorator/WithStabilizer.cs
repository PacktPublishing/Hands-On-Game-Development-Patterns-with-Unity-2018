public class WithStabilizer : RifleDecorator
{
    private float m_StabilizerAccurancy = 10.0f;

    public WithStabilizer(IRifle rifle) : base(rifle) {}

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_StabilizerAccurancy;
    }
}