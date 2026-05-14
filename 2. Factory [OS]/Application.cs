public class Application(Factory factory, string key)
{
    //private string Factory = factory;
    public void Logic()
    {
        factory.Generate(key);
    }
}