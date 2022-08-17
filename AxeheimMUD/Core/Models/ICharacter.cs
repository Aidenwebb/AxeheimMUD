namespace AxeheimMUD.Core.Models;

public interface ICharacter
{
    string Name { get; }
    int Position { get; }

    void Move(int roomNumber);
}