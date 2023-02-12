namespace tetofo.EventBus.Impl;

public abstract class BaseCallback : ICallback
{
    public ISet<Type>? WhiteList { get; set; }

    public BaseCallback(params Type[] types)
    {
        WhiteList = new HashSet<Type>();
        foreach(Type t in types)
        {
            WhiteList.Add(t);            
        }
    }

    public abstract void Callback(IEvent iEvent);

}