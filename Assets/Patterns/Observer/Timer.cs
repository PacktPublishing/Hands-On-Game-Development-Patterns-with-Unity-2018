using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{
    private float m_Duration = 10.0f;
    private float m_HalfTime;

    public delegate void TimerStarted();
    public static event TimerStarted OnTimerStarted;

    public delegate void HalfTime();
    public static event HalfTime OnHalfTime;

    public delegate void TimerEnded();
    public static event TimerEnded OnTimerEnded;

    private IEnumerator m_Coroutine;

    IEnumerator Start()
    {
        m_HalfTime = m_Duration / 2;

        if (OnTimerStarted != null)
        {
            OnTimerStarted();
        }

        yield return StartCoroutine(WaitAndPrint(1.0F));

        if (OnTimerEnded != null)
        {
            OnTimerEnded();
        }
    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (Time.time < m_Duration)
        {
            yield return new WaitForSeconds(waitTime);

            Debug.Log("Seconds: " + Mathf.Round(Time.time));

            if (Mathf.Round(Time.time) == Mathf.Round(m_HalfTime))
            {
                if (OnHalfTime != null)
                {
                    OnHalfTime();
                }
            }
        }
    }
}