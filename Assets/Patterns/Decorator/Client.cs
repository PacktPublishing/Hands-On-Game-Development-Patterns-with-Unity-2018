using UnityEngine;

namespace Pattern.Decorator
{
    public class Client : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown("b"))
            {
                IRifle rifle = new BasicRifle();
                Debug.Log("Rifle has a basic configuration, current accurancy: " + rifle.GetAccuracy());
            }

            if (Input.GetKeyDown("s"))
            {
                IRifle rifle = new BasicRifle();
                rifle = new WithScope(rifle);
                Debug.Log("Rifle is equipped with a scope, current accurancy: " + rifle.GetAccuracy());
            }

            if (Input.GetKeyDown("t"))
            {
                IRifle rifle = new BasicRifle();
                rifle = new WithScope(new WithStabilizer(rifle));
                Debug.Log("Rifle is equipped with a scope and stabilizer, current accurancy: " + rifle.GetAccuracy());
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
}
