public class EventManager
{
    public List<ISubscriber> Subscribers = [];

    public void NotifySubscribers()
    {
        foreach(var sub in Subscribers)
            sub.Update();
    }

    public void AddSubscriber(ISubscriber subscriber)
    => Subscribers.Add(subscriber);

    public void RemoveSubscriber(ISubscriber subscriber)
    => Subscribers.Remove(subscriber);
}