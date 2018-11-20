using UnityEngine;

public class Enemy : MonoBehaviour, iCopyable
{
    // Implement any common enemy type functionality.

    public iCopyable Copy()
    {
        return Instantiate(this); // Basically copying the current instance.
    }
}
