namespace Yellow_Belt_Katas;

public class Enemy : CombatBase
{
    public Enemy(string _name, int _health, int _damage)
    {
        name = _name;
        health = _health;
        damage = _damage;
    }
}