using UnityEngine;

public class Buzzer : MonoBehaviour
{
    void OnEnable()
    {
        Timer.OnTimerStarted += PlayStartBuzzer;
        Timer.OnTimerEnded += PlayEndBuzzer;
    }

    void OnDisable()
    {
        Timer.OnTimerStarted -= PlayStartBuzzer;
        Timer.OnTimerEnded -= PlayEndBuzzer;
    }

    void PlayStartBuzzer()
    {
        Debug.Log("[BUZZER] : Play start buzzer!");
    }

    void PlayEndBuzzer()
    {
        Debug.Log("[BUZZER] : Play end buzzer!");
    }
}
