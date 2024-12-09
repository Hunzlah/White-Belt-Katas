namespace Yellow_Belt_Katas;

public class Player : CombatBase
{
    public Player(string _name, int _health, int _damage)
    {
        name = _name;
        health = _health;
        damage = _damage;
    }

    public void Heal(int amount)
    {
        health += amount;
        Console.WriteLine($"{name} healed {amount} health");
    }
}