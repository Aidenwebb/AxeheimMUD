namespace AxeheimMUD.Core.Models;

public interface IFightable
{
    int MaxHealth { get; }
    int CurrentHealth { get; }
    int Level { get; }
    void Attack(IFightable target);
    int Defend(IFightable attacker, int damage);
}