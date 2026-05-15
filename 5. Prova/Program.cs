
Trainer trainer = new();
Boss enemy = new("Red Dragon"); // SET ENEMY

trainer.NewTraining("mage", () => new Mage());
trainer.NewTraining("warrior", () => new Warrior());
trainer.NewTraining("tank", () => new Tank());

Guild guild = new Guild(trainer, enemy);

Console.WriteLine("\n===== PREPARE FOR BATTLE =====");

int mage = 6;
int warrior = 2;
int tank = 2;

for (int i =0; i<mage; i++)
    guild.Recruit("mage");

for (int i =0; i<warrior; i++)
    guild.Recruit("warrior");

for (int i =0; i<tank; i++)
    guild.Recruit("tank");


enemy.eventManager.NewTarget(guild);

Console.WriteLine("\n===== BATTLE STARTED =====");
for (int i=0; i < 5; i++)
{
    Console.WriteLine($"\n------ {enemy.Name} ------");
    Console.WriteLine($"....... HP: {enemy.hp} .......");
    guild.Attack();
    enemy.Act();

    if(guild.players.Count <= 0)
    {
        Console.WriteLine($"====== DEFEAT ======");
        System.Console.WriteLine("Your team was slayered....");
        break;
    }
        


    if(enemy.hp <= 0)
    {
        Console.WriteLine($"====== CONGRATULATIONS ======");
        Console.WriteLine($"Your team slayered {enemy.Name}!");
        Console.WriteLine($"Players: {guild.players}");
        break;
    }
}
