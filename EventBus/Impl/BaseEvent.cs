using tetofo.Model;

namespace tetofo.EventBus.Impl;

public class BaseEvent : IEvent
{
    public IData? Payload { get; set; }
    public IAuthor? Author { get; set; }
}