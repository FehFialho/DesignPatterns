using Doke.Pokedex;
using Doke.Pokedex.Enum;

Console.WriteLine(new string('=',40) + "Poke Battle!" + new string('=',40));


Attack psychic = new ("Psychic", 5, PokemonType.Psychic);
Attack psyshock = new ("Psyshock", 7, PokemonType.Psychic);
Attack shadowBall = new ("Shadow Ball", 10, PokemonType.Dark);
Attack scratch = new ("Scratch", 2, PokemonType.Normal);

List<Attack> meowsticAttacks = [psychic, psyshock, shadowBall];

Pokemon meowstic = new ("Meowstic", 20, PokemonType.Psychic, meowsticAttacks);