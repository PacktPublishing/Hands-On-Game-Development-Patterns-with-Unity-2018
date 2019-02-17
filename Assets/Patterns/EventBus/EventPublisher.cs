using UnityEngine;

public class EventPublisher : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            EventBus.TriggerEvent("Shoot");
        }

        if (Input.GetKeyDown("l"))
        {
            EventBus.TriggerEvent("Launch");
        }
    }

    void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Label(new Rect(10, 10, 500, 20), "Press S to shoot.");
        GUI.Label(new Rect(10, 30, 500, 20), "Press L to launch.");
        GUI.Label(new Rect(10, 50, 500, 20), "Look in the Debug Console to view the results of the event calls.");
    }
}