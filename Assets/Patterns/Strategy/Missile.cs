using UnityEngine;

abstract public class Missile : ScriptableObject
{
    protected ISeekBehaviour seekBehavior;

    public void ApplySeek()
    {
        seekBehavior.Seek();
    }

    public void SetSeekBehavior(ISeekBehaviour seekType)
    {
        seekBehavior = seekType;
    }
}
