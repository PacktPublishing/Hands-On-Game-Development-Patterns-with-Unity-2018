using UnityEngine;

public class JetEngine : IEngine
{
    public void StartEngine()
    {
        ActivateJetStream();
        Debug.Log("Engine started");
    }

    private void ActivateJetStream()
    {
        Debug.Log("The jet stream is activated");
    }
}
