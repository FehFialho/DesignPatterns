using System.Net.Mail;
using Doke.Pokedex;
using Doke.Pokedex.Enum;

Console.WriteLine(new string('=',40) + "Poke Battle!" + new string('=',40));


Attack psychic = new ("Psychic", 5, PokemonType.Psychic);
Attack psyshock = new ("Psyshock", 7, PokemonType.Psychic);
Attack shadowBall = new ("Shadow Ball", 10, PokemonType.Dark);
Attack scratch = new ("Scratch", 2, PokemonType.Normal);

List<Attack> meowsticAttacks = [psychic, psyshock, shadowBall];

// Pokemons
Pokemon meowsticMale = new ("Meowstic ⚦", 20, PokemonType.Psychic, meowsticAttacks);
Pokemon meowsticFemale = new ("Meowstic ♀", 22, PokemonType.Psychic, meowsticAttacks);

// Define Battle Poke
Pokemon poke1 = meowsticMale;
Pokemon poke2 = meowsticFemale;

bool alive1 = true;
bool alive2 = true;

// BATTLE!
while (alive1 && alive2)
{
    Console.WriteLine($"\n" + new string('=',10) + $" {poke1.Name} [{poke1.Hp}] " + new string('=',10) + "    VS    " + new string('=',10) + $" {poke2.Name} [{poke2.Hp}] " + new string('=',10));

    alive2 = poke2.ReceiveDamage(poke1.RandomAttack(poke2));
    if (!alive2) break;

    Console.WriteLine(new string('-',10)); 

    alive1 = poke1.ReceiveDamage(poke2.RandomAttack(poke1));
}


