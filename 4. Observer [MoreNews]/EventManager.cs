public class EventManager
{
    public Dictionary<string, List<ISubscriber>> Subscribers = [];
    public void Notify(string newsType)
    {

        if(!Subscribers.ContainsKey(newsType))
            Subscribers.Add(newsType, []);

        foreach (var sub in Subscribers[newsType])
            sub.NotifySub(newsType);
    }

    public void AddSubscriber(ISubscriber subscriber, string newsType)
    {

        if(!Subscribers.ContainsKey(newsType))
            Subscribers.Add(newsType, []);

        Subscribers[newsType].Add(subscriber);
    }
}