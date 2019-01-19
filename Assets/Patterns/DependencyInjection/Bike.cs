using UnityEngine;

public class Bike : MonoBehaviour
{
    private IEngine m_Engine;
    private IDriver m_Driver;

    public void SetEngine(IEngine engine)
    {
        m_Engine = engine;
        Debug.Log("The bike is running with the engine: " + m_Engine);
    }

    public void SetDriver(IDriver driver)
    {
        m_Driver = driver;
        Debug.Log("The driver of the bike is a: " + driver);
    }
}
