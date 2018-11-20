using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public void Shoot(float range, float damage)
    {
        Debug.Log("Shooting @" + range * damage);
    }
}
