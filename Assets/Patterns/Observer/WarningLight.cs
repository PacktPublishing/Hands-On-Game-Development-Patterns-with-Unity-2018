using UnityEngine;

public class WarningLight : MonoBehaviour
{
    void OnEnable()
    {
        Timer.OnHalfTime += BlinkLight;
    }

    void OnDisable()
    {
        Timer.OnHalfTime -= BlinkLight;
    }

    void BlinkLight()
    {
        Debug.Log("[WARNING LIGHT] : It's half-time, blinking the warning light!");
    }
}
