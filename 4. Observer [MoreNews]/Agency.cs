public class Agency
{
    public EventManager eventManager { get; set; } = new();


    public void postNews(string newsType)
    {
        eventManager.Notify(newsType);
    }
}