using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using tetofo.DesignPattern;


namespace tetofo.EventBus.Impl;

public class BaseEventBus : IEventBus
{
    private ILogger<BaseEventBus> _logger;
    private ISupplier<IHost> _hostSupplier;

    public BaseEventBus
    (
        ILogger<BaseEventBus> logger,
        ISupplier<IHost> hostSupplier
    )
    {
        _logger = logger;
        _hostSupplier = hostSupplier;
    }

    public void Event<S>(S s) where S : IEvent
    {
        _logger.LogInformation($"EVENT: {s.GetType()}");
        IEnumerable<ICallback> callbacks = _hostSupplier.Get().Services.GetServices<ICallback>();
        
        foreach(ICallback callback in callbacks)
        {
            if (callback.WhiteList == null)
            {
                callback.Callback(s);
                continue;
            }
            if(callback.WhiteList.Count == 0)
            {
                callback.Callback(s);
                continue;
            }
            if (callback.WhiteList.Contains(s.GetType()))
            {
                callback.Callback(s);
            }
        }
    }
}