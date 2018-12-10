using UnityEngine;

public class ClientServiceLocator : MonoBehaviour
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
    }
}
