using System;
using System.Collections.Generic;

public class ServiceLocator : Singleton<ServiceLocator>
{
    private IDictionary<object, object> m_Services;

    public override void Awake()
    {
        base.Awake();
        FillRegistry();
    }

    private void FillRegistry()
    {
        m_Services = new Dictionary<object, object>();

        m_Services.Add(typeof(LobbyCoordinator), new LobbyCoordinator());
        m_Services.Add(typeof(CurrencyConverter), new CurrencyConverter());
        m_Services.Add(typeof(LightingCoordinator), new LightingCoordinator());
    }

    public T GetService<T>()
    {
        try
        {
            return (T)m_Services[typeof(T)];
        }
        catch
        {
            throw new ApplicationException("The requested service is not found.");
        }
    }
}
