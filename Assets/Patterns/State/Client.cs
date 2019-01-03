using UnityEngine;

namespace Pattern.State
{
    public class Client : MonoBehaviour
    {
        public Ship ship;

        void Update()
        {
            if (Input.GetKeyDown("n"))
            {
                ship.Normalize();
            }

            if (Input.GetKeyDown("a"))
            {
                ship.TriggerRedAlert();
            }

            if (Input.GetKeyDown("d"))
            {
                ship.DisableShip();
            }
        }

        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 50, 300, 30), "Press N to switch state of the ship to normal.");
            GUI.Label(new Rect(10, 30, 300, 30), "Press A to switch state of the ship to alerted.");
            GUI.Label(new Rect(10, 10, 300, 30), "Press D to switch state of the ship to disabled.");
            GUI.Label(new Rect(10, 90, 500, 30), "Output of the commands are displayed in the console.");
        }
    }
}
