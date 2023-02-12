namespace tetofo.EventBus;

public interface ICallback
{
    ISet<Type> ? WhiteList { get; set; }
    void Callback(IEvent iEvent);
}