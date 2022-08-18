namespace AxeheimMUD.Core.Models;

public interface ICharacter: IMapObject
{
    string Name { get; }

    void Move(int roomNumber);
}