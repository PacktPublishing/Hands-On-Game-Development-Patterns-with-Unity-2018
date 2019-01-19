using UnityEngine;

namespace Pattern.DependencyInjection
{
    public class Client : MonoBehaviour
    {
        public Bike m_Bike;

        private IDriver m_Driver;
        private IEngine m_Engine;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                m_Engine = new JetEngine();
                m_Bike.SetEngine(m_Engine);

                m_Driver = new HumanDriver();
                m_Bike.SetDriver(m_Driver);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                m_Engine = new NitroEngine();
                m_Bike.SetEngine(m_Engine);

                m_Driver = new AndroidDriver();
                m_Bike.SetDriver(m_Driver);
            }
        }

        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 500, 20), "Press H to load up a bike with a jet engine + human driver.");
            GUI.Label(new Rect(10, 30, 500, 20), "Press A to load up a bike with a nitro engine + android driver.");
            GUI.Label(new Rect(10, 50, 500, 20), "Look in the Debug Console to view the robot parts status.");
        }
    }
}