public class WithScope : RifleDecorator
{
    private float m_ScopeAccurancy = 20.0f;

    public WithScope(IRifle rifle) : base(rifle) {}

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_ScopeAccurancy;
    }
}