using System.Globalization;
using Doke.Pokedex;
using Doke.Pokedex.Enum;
public class Pokemon
{
    public string Name { get; set; }
    public int MaxHp { get; set; }
    public int Hp { get; set; }
    public PokemonType Type { get; set; }
    public List<Attack> Attacks { get; set; }

    public Pokemon (string name, int maxHp, PokemonType type, List<Attack> attacks)
    {
        Name = name;
        MaxHp = maxHp;
        Hp = maxHp;
        Type = type;
        Attacks = attacks;
    }

    // Returns Damage
    public int RandomAttack(Pokemon target)
    {
        Random rnd = new Random();
        int randomNum = rnd.Next(0, Attacks.Count - 1);
        Attack chosedAttack = Attacks[randomNum];
        Console.WriteLine($"{Name} used {chosedAttack.Name}!"); 

        float multiplier = Multiplier.GetMultiplier(chosedAttack.Type, target.Type);
        int damage = (int)(chosedAttack.Damage * multiplier);
        return damage;
    }

    // Considerate Defense Later
    // Returns if the pokemon is alive (bool)
    public bool ReceiveDamage(int damage)
    {
        Console.WriteLine($"{Name} received {damage} damage!"); 
        Hp = Hp - damage;
        // Console.WriteLine($"[{Name}] HP: {Hp}"); 
        if (Hp <= 0)
        {
            Hp = 0;
            Console.WriteLine($"{Name} fainted..."); 
            return false;
        }
        return true;
    }
}