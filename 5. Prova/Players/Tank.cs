public class Tank : IPlayer
{
    public int hp { get; set; } = 100;
    public void Attack(Boss target)
    {
        System.Console.WriteLine("[Tank] 15 Damage!");
        target.ReceiveDamage(15);
    }

    public void ReceiveDamage(int damage)
    {
        hp = hp - damage;
            if (hp <0)
                hp=0;
    }
}