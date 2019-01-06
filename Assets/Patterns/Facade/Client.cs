using UnityEngine;

namespace Pattern.Facade
{
    public class Client : MonoBehaviour
    {
        private Player m_Player;

        void Start()
        {
            m_Player = new Player();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                // Save the current player instance.
                SaveManager.Instance.SaveGame(m_Player);
            }
        }

        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 300, 30), "Press S to save the game.");
            GUI.Label(new Rect(10, 30, 500, 30), "Output of the commands are displayed in the console.");
        }
    }
}
