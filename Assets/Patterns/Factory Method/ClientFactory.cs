using UnityEngine;

public class ClientFactory : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_SpawnerNPC.SpawnVillagers();
        }
    }

    void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Label(new Rect(10, 10, 200, 20), "Press S to spawn NPCs.");
        GUI.Label(new Rect(10, 30, 300, 20), "Look in the Debug Console to see them speak.");
    }
}
