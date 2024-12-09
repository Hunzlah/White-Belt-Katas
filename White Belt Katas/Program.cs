// See https://aka.ms/new-console-template for more information

using Yellow_Belt_Katas;

Player player1 = new Player("Hero", 50, 20);

Enemy enemy1 = new Enemy("Goblin", 50, 20);

while (!player1.IsDead() && !enemy1.IsDead())
{
    player1.DisplayHealth();
    enemy1.DisplayHealth();
    
    int action = Utilities.GetInputInRange(1, 2, new string[] { "Attack", "Heal" });

    switch ((ActionType)action)
    {
        case ActionType.Heal:
            player1.Heal(10);
            break;
        case ActionType.Attack:
            player1.Attack(enemy1);
            break;
    }
    
    if(enemy1.IsDead()) continue;
    
    enemy1.Attack(player1);
}

if (enemy1.IsDead())
{
    Console.WriteLine("Congratulations! Hero has defeated the Goblin!");
}
else
{
    Console.WriteLine("Goblin has defeated the Hero!");
}


enum ActionType
{
    Attack = 1, Heal = 2
}