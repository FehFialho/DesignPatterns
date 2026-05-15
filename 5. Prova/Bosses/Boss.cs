using System.Runtime.Serialization;

public class Boss (string name)
{
    public string Name { get; set; } = name;
    public int hp { get; set; } = 800;
    public EventManager eventManager = new();
    public IStrategy Strategy { get; set; }

    public void SetStrategy(IStrategy strategy)
    {
        this.Strategy = strategy;
    }

    public void Act()
    {

        if(eventManager.Enemies.Count <= 0)
            return;

        if (hp<=0)
            return;

        if (Strategy == null)
            SetStrategy(new Default());

        Console.WriteLine($"[{Name}] {Strategy.Message}");
        int damage = Strategy.Attack(this);
        eventManager.NotifyAttack(damage);
        System.Console.WriteLine($"[{Name}] Dealt {damage} Damage!");
    }

    public void ReceiveDamage(int damage)
    {
        hp = hp - damage;
            // Console.WriteLine($"[{Name}] Take {damage} damage!");
        if (hp < 0)
        {
            hp = 0;
            Console.WriteLine($"[{Name}] Has been slayed!");
        }
    }
}