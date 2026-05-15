using System.Collections.Concurrent;

public class Guild(Trainer trainer, Boss target)
{
    public Boss target = target;
    public List<IPlayer> players = [];
    public void Recruit(string key)
    {
        players.Add(trainer.TrainPlayer(key));
    }

    public void Attack()
    {
        foreach(var player in players)
        {
            player.Attack(target);
            if(target.hp <= 0)
                return;
        }
    }
    
    public void Check(int damage)
    {
        List<IPlayer> died_players = [];
        
        foreach(var player in players)
        {
            player.ReceiveDamage(damage);
            // System.Console.WriteLine($"[{player}] Received {damage} damage!");
            // System.Console.WriteLine(player.hp);
            if(player.hp <= 0){
                Console.WriteLine($"A {player} died...");
                died_players.Add(player);
            }
        }

        foreach(var dead in died_players)
        {
            players.Remove(dead);
        }
    }
}