namespace AxeheimMUD.Core.Models;

public class Monster: IFightable, ICharacter
{
    private Random _random = new Random();

    public int MaxHealth { get; protected set; }

    public int CurrentHealth
    {
        get
        {
            return _currentHealth;
        }
    }
    private int _currentHealth;
    const int DEFAULT_DAMAGE = 5;
    public int Level { get; protected set; }
    public string ObjectType { get; protected set; }
    public string Name { get; protected set; }
    public int Position { get; protected set; }

    public Monster(int level, string name, int position)
    {
        MaxHealth = 10 + (level*2);
        _currentHealth = MaxHealth;
        Level = level;
        Name = name;
        Position = position;
        ObjectType = "Monster";
    }

    public void Move(int roomNumber)
    {
        Position = roomNumber;
    }

    public void Attack(IFightable target)
    {
        int damage = _random.Next(Level + DEFAULT_DAMAGE);
        ICharacter character = (ICharacter)target;
        Console.WriteLine($"Attacking {character.Name} for {damage}");
        target.Defend(this, damage);
    }

    public int Defend(IFightable attacker, int damage)
    {
        if (_currentHealth < damage)
        {
            int returnValue = _currentHealth;
            _currentHealth = 0;
            return returnValue;
        }
        else
        {
            _currentHealth -= damage;
            return damage;
        }

    }
}