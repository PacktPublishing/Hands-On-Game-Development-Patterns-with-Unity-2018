using UnityEngine;

public class Sniper : Enemy, iCopyable
{
    public iCopyable Copy()
    {
        return Instantiate(this);
    }
}
