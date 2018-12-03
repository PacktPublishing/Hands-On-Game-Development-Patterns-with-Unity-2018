using UnityEngine;

public class Cannon : MonoBehaviour
{
    void OnEnable()
    {
        EventBus.StartListening("Shoot", Shoot);
    }

    void OnDisable()
    {
        EventBus.StopListening("Shoot", Shoot);
    }

    void Shoot()
    {
        Debug.Log("Received a shoot event : shooting cannon!");
    }
}