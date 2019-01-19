using UnityEngine;

namespace Pattern.AbstractFactory
{
    public class Client : MonoBehaviour
    {
        public NPCSpawner m_SpawnerNPC;

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                m_SpawnerNPC.SpawnHumans();
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                m_SpawnerNPC.SpawnAnimals();
            }
        }

        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 200, 20), "Press U to spawn humans.");
            GUI.Label(new Rect(10, 30, 200, 20), "Press A to spawn animals.");
            GUI.Label(new Rect(10, 50, 300, 20), "Look in the Debug Console to see them speak.");
        }
    }
}
