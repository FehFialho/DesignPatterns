public interface IPlayer
{
    public int hp { get; set; }
    public void Attack(Boss target);
    public void ReceiveDamage(int damage);
}