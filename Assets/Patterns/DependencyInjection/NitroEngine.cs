using UnityEngine;

public class NitroEngine : IEngine
{
    public void StartEngine()
    {
        OpenNitroValve();
        Debug.Log("Engine started");
    }

    private void OpenNitroValve()
    {
        Debug.Log("The nitro valve is open");
    }
}
