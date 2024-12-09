namespace Yellow_Belt_Katas;

public class CombatBase
{
    protected string name;
    protected int health;
    protected int damage;

    public void Attack(CombatBase defender)
    {
        Console.WriteLine($"{name} attacks the {defender.name}");
        defender.TakeDamage(damage);
    }

    private void TakeDamage(int amount)
    {
        health = health - amount < 0 ? 0 : health - amount;
        Console.WriteLine($"{name} takes {amount} damage");
    }

    public bool IsDead()
    {
        return health <= 0;
    }

    public void DisplayHealth()
    {
        Console.WriteLine($"{name}'s health: {health}");
    }
}