using UnityEngine;

public class Bike : MonoBehaviour
{
    private IEngine m_Engine;
    private IDriver m_Driver;

    public void SetEngine(IEngine engine)
    {
        m_Engine = engine;
    }

    public void SetDriver(IDriver driver)
    {
        m_Driver = driver;
    }

    public void StartEngine()
    {
        // Starting the engine
        m_Engine.StartEngine();
        
        // Giving control of the bike to a driver (AI or player)
        m_Driver.Control(this);
    }

    public void TurnLeft()
    {
        Debug.Log("The bike is turning left");
    }

    public void TurnRight()
    {
        Debug.Log("The bike is turning right");
    }
}
