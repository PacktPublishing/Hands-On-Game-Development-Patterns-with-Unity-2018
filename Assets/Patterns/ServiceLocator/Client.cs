using UnityEngine;

namespace Pattern.ServiceLocator_
{
    public class Client : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown("o"))
            {
                ServiceLocator.Instance.GetService<LightingCoordinator>().TurnOffLights();
            }

            if (Input.GetKeyDown("c"))
            {
                ServiceLocator.Instance.GetService<CurrencyConverter>().ConvertToUsDollar(10);
            }

            if (Input.GetKeyDown("l"))
            {
                ServiceLocator.Instance.GetService<LobbyCoordinator>().AddPlayerToLobby();
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
}