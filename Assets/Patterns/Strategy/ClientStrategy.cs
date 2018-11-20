using UnityEngine;

public class ClientStrategy : MonoBehaviour
{
	void Update ()
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
            sideWinderWithSonar.setSeekBehavior(sonar);
            sideWinderWithSonar.ApplySeek();
        }
    }
}
