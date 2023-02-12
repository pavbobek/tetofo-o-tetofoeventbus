namespace tetofo.EventBus;

public interface IEventBus
{
    void Event<S>(S s) where S : IEvent;
}