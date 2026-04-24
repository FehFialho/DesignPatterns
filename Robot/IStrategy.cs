public interface IStrategy
{
    public string Message { get; }
    public void Execute(Robot robot);
}

public class Default : IStrategy
{
    public string Message { get; } = "Walking...";

    public void Execute(Robot robot)
    {
        if(Random.Shared.Next(1,5) == 1)
        {
            if(Random.Shared.Next(1,5) == 1)
                robot.SetStrategy(new Hacked());
            else
                robot.SetStrategy(new Fight());       
        }
    }
}

public class Fight : IStrategy
{
    public string Message { get; } = "Fighting!";
    public void Execute(Robot robot)
    {
        if(Random.Shared.Next(1,21) == 1)
            robot.SetStrategy(new Hacked());
    }
}

public class Hacked : IStrategy
{
    public string Message { get; } = "H̴a̷c̴k̶e̴d̶";
    public void Execute(Robot robot)
    {
    }
};