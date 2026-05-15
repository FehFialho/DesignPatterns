public class Subscriber : ISubscriber
{
    public void NotifySub(string newsType)
    {
        System.Console.WriteLine($"I read the {newsType} news!");
    }
}