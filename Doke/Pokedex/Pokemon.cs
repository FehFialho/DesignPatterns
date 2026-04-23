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
        Type = type;
        Attacks = attacks;
    }

    // Returns Damage
    public int RandomAttack()
    {
        Random rnd = new Random();
        int randomNum = rnd.Next(0, Attacks.Count - 1);
        Attack chosedAttack = Attacks[randomNum];
        return chosedAttack.Damage;
    }


}