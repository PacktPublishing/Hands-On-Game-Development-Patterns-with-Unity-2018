using UnityEngine;

namespace Pattern.Command_
{
    public class Client : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                RemoteControlDevice receiver = new TelevisionReceiver();
                Command command = new TurnOnCommand(receiver);
                Invoker invoker = new Invoker();

                invoker.SetCommand(command);
                invoker.ExecuteCommand();
            }

            if (Input.GetKeyDown(KeyCode.S))
            {

            }
        }

        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 500, 20), "Press O to wake up the robot.");
            GUI.Label(new Rect(10, 30, 500, 20), "Press S to shutdown the robot.");
            GUI.Label(new Rect(10, 50, 500, 20), "Look in the Debug Console to view the robot parts status.");
        }
    }
}
