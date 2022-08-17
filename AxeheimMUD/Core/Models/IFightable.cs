namespace AxeheimMUD.Core.Models;

public interface IFightable
{
    int MaxHealth { get; }
    int CurrentHealth { get; }
    int Level { get; }
    void Attack(IFightable target);
    void Defend(IFightable attacker, int damage);
}