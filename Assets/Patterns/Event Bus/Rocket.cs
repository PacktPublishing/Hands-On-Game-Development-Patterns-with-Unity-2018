using UnityEngine;

public class Rocket : MonoBehaviour
{
    private bool m_IsLaunched = false;

    void OnEnable()
    {
        EventBus.StartListening("Launch", Launch);
    }

    void OnDisable()
    {
        EventBus.StopListening("Launch", Launch);
    }

    void Launch()
    {
        if (m_IsLaunched == false)
        {
            m_IsLaunched = true;
            Debug.Log("Received a launch event : rocket launching!");
        }
    }
}