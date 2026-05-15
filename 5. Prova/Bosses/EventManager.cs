public class EventManager
{
    public List<Guild> Enemies = [];

    public void NotifyAttack(int damage)
    {
        foreach(var guild in Enemies)
            guild.Check(damage);
    }

    public void NewTarget(Guild target)
    => Enemies.Add(target);

    public void RemoveTarget(Guild target)
    => Enemies.Remove(target);
}