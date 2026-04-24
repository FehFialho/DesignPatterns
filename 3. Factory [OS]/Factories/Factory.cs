using System.Reflection.Metadata.Ecma335;

public class Factory
{
    Dictionary<string, Func<IButton>> dict = [];

    public void AddFactory(string name, Func<IButton> factory)
    {
        dict.Add(name, factory);
    }

    public void Generate(string key)
    {
        var c = dict[key].Invoke();
        Console.WriteLine($"Generated {c} element!");
    }
}