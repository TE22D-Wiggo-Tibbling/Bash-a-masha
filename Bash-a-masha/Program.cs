Random random = new Random();

Skill attack = new()
{
    Name = "Attack enemy",
    ManaCost = 10,
    HealSelfAmount = 0,
    DamageEnemyAmount = random.Next(5, 16)
};

Skill heal = new()
{
    Name = "heal self",
    ManaCost = 20,
    HealSelfAmount = random.Next(5, 16),
    DamageEnemyAmount = 0
};

Charakters player1 = new()
{
    Name = "player1",


    Mana = 100
};

Charakters player2 = new()
{
    Name = "player2",

    Mana = 100
};

Skill active = attack;

    string awnser;
    int enemyAction;
while (player1.Health > 0 && player2.Health > 0)
{

    Console.WriteLine(player1.Name + " (" + player1.Health + ")" + "  " + player2.Name + " (" + player2.Health + ")");
    System.Console.WriteLine("What you wana dooooooo");
    System.Console.WriteLine("attack (a) or heal (h)");
    awnser = Console.ReadLine();
    if (awnser == "a" || awnser == "A")
    {
        active = attack;
    }
    else if (awnser == "h")
    {
        active = heal;
    }
    else
    {
        System.Console.WriteLine("to bad");
        Console.ReadLine();
        Environment.Exit(0);
    }
    Action(player1, player2, active);


    enemyAction=random.Next(0,2);

    if(enemyAction == 0) active = attack;
    if(enemyAction == 1) active = heal;

    Action(player2,player1,active);
}

Console.WriteLine(player1.Name + " (" + player1.Health + ")" + "  " + player2.Name + " (" + player2.Health + ")");
Console.ReadLine();



void Action(Charakters me, Charakters mål, Skill skill)
{

    me.Health += skill.HealSelfAmount;
    me.Mana -= skill.ManaCost;
    mål.Health -= skill.DamageEnemyAmount;
}