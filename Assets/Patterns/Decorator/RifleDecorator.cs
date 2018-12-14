using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class RifleDecorator : MonoBehaviour, IRifle
{
    protected IRifle m_TempRifle;

    public string GetDescription()
    {
        return m_TempRifle.GetDescription();
    }

    public float GetStrength()
    {
        return m_TempRifle.GetStrength();
    }
}
