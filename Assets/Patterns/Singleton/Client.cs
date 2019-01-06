using UnityEngine;

namespace Pattern.Singleton
{
    public class Client : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                GameManager.Instance.InitializeGame();
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                InventoryManager.Instance.AddItem(001);
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                InventoryManager.Instance.RemoveItem(023);
            }
        }

        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 300, 30), "Press I to initialize the game.");
            GUI.Label(new Rect(10, 30, 300, 30), "Press A to add an item to the inventory.");
            GUI.Label(new Rect(10, 50, 300, 30), "Press R to remove an item to the inventory.");
            GUI.Label(new Rect(10, 80, 500, 30), "Output of the commands are displayed in the console.");
        }
    }
}