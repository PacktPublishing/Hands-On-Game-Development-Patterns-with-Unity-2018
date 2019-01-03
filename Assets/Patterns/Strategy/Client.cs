using UnityEngine;

namespace Pattern.Strategy
{
    public class Client : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                // Applying default seeking behaviour to missiles.
                Missile sideWinder = ScriptableObject.CreateInstance<SideWinder>();
                sideWinder.ApplySeek();

                Missile tomahawk = ScriptableObject.CreateInstance<Tomahawk>();
                tomahawk.ApplySeek();

                Missile torpedo = ScriptableObject.CreateInstance<Torpedo>();
                torpedo.ApplySeek();

                // Applying custom seeking behaviour to a SideWinder;
                Missile sideWinderWithSonar = ScriptableObject.CreateInstance<SideWinder>();
                ISeekBehaviour sonar = new SeekWithSonar();
                sideWinderWithSonar.SetSeekBehavior(sonar);
                sideWinderWithSonar.ApplySeek();
            }
        }

        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 500, 20), "Press D to load a set of missiles and apply a seeking strategy to them.");
            GUI.Label(new Rect(10, 30, 500, 20), "Look in the Debug Console to view the missile being launched.");
        }
    }
}
