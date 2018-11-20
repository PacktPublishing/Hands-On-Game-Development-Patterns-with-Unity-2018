using UnityEngine;

abstract public class Missile : ScriptableObject
{
    protected ISeekBehaviour seekBehavior;

    public void ApplySeek()
    {
        seekBehavior.Seek();
    }

    public void setSeekBehavior(ISeekBehaviour seekType)
    {
        seekBehavior = seekType;
    }
}
