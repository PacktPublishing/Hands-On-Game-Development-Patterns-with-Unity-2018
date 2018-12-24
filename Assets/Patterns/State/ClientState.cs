using UnityEngine;

public class ClientState : MonoBehaviour
{
    public Ship ship;

    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            ship.DisableShip();
        }

        if (Input.GetKeyDown("s"))
        {
        }

        if (Input.GetKeyDown("t"))
        {
        }
    }

    void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Label(new Rect(10, 10, 300, 30), "Press B to build a basic rifle.");
        GUI.Label(new Rect(10, 30, 300, 30), "Press S to add a scope to the rifle.");
        GUI.Label(new Rect(10, 50, 300, 30), "Press T to add a scope and stabilizer to the rifle.");
    }
}
