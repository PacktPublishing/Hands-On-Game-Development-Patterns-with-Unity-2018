using UnityEngine;

public class Ship : MonoBehaviour
{
    private IShipState m_CurrentState;

    void Awake ()
    {
        m_CurrentState = new DisabledShipState();
        m_CurrentState.Execute(this);

        m_CurrentState = new AlertShipState();
        m_CurrentState.Execute(this);
    }

    public void LogStatus(string status)
    {
        Debug.Log(status);
    }
}
