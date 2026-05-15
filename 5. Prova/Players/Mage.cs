public class Mage : IPlayer
{
    public int hp { get; set; } = 30;
    public void Attack(Boss target)
    {
        Console.WriteLine("[Mage] 60 Damage!");
        target.ReceiveDamage(60);
        target.SetStrategy(new Furious());
    }

    public void ReceiveDamage(int damage)
    {
        hp = hp - damage;
            if (hp <0)
                hp=0;
    }
}