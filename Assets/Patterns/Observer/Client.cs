using UnityEngine;

namespace Pattern.Observer
{
    public class Client : MonoBehaviour
    {
        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 500, 20), "Look at the console window to watch the countdown and the events getting triggered.");
        }
    }
}
