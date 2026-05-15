public class CommonSubscriber : ISubscriber
{
    public void Update()
    {
        var i = Random.Shared.Next(1,5);
        if(i == 1)
            Console.WriteLine("++ Social Points");
        else
            Console.WriteLine("-- Social Points");
    }
}