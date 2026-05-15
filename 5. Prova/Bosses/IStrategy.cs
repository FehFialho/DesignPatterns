public interface IStrategy
{
    public string Message { get; }
    public int Attack(Boss boss);
}

public class Default : IStrategy
{
    public string Message { get; } = "Attacking!";

    public int Attack(Boss boss)
    {
        return Random.Shared.Next(0,31);
    }
}

public class Furious : IStrategy
{
    public string Message { get; } = "Furious and Attacking!";

    public int Attack(Boss boss)
    {
        return Random.Shared.Next(0,61);
    }
}