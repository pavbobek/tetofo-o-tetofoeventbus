using tetofo.Model;

namespace tetofo.EventBus;

public interface IEvent 
{
    IData? Payload { get; set; }
    IAuthor? Author { get; set; }
}