public class Trainer
{
    Dictionary<string, Func<IPlayer>> dict = [];

    public void NewTraining(string name, Func<IPlayer> factory)
    {
        dict.Add(name, factory);
    }

    public IPlayer TrainPlayer(string key)
    {
        var player = dict[key].Invoke();
        Console.WriteLine($"[Guild] Recruited {player} player!");
        return player;
    }
}