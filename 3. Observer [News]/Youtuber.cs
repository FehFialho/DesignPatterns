public class Youtuber
{
    public EventManager eventManager {get;set;} = new();

    public void PostVideo()
    {
        Console.WriteLine("New Video Posted!");
        eventManager.NotifySubscribers();
    }
}