public class Warrior : IPlayer
{
    public int hp { get; set; } = 60;
    public void Attack(Boss target)
    {
        System.Console.WriteLine("[Warrior] 30 Damage!");
        target.ReceiveDamage(30);
    }

    public void ReceiveDamage(int damage)
    {
        hp = hp - damage;
            if (hp <0)
                hp=0;
    }
}