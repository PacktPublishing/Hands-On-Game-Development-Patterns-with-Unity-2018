using UnityEngine;

public class ClientDecorator : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("o"))
        {
            //
        }
    }

    void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Label(new Rect(10, 10, 300, 30), "Press O to turn of the lights.");
        GUI.Label(new Rect(10, 30, 300, 30), "Press C to convert in-game currency.");
        GUI.Label(new Rect(10, 50, 300, 30), "Press L to add player to the lobby.");
        GUI.Label(new Rect(10, 90, 500, 30), "Output of the commands are displayed in the console.");
    }
}
