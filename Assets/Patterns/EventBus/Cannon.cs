using UnityEngine;

public class Cannon : MonoBehaviour
{
    private bool m_IsQuitting;

    void OnEnable()
    {
        EventBus.StartListening("Shoot", Shoot);
    }

    void OnApplicationQuit()
    {
        m_IsQuitting = true;
    }

    void OnDisable()
    {
        if (m_IsQuitting == false)
        {
            EventBus.StopListening("Shoot", Shoot);
        }
    }

    void Shoot()
    {
        Debug.Log("Received a shoot event : shooting cannon!");
    }
}