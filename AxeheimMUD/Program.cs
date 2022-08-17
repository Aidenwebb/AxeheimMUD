using AxeheimMUD.Core.Models;

namespace AxeheimMUD
{
    internal class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Monster monster = new Monster(1, "monster", 1);
            PlayerCharacter player = new PlayerCharacter(5, "James", 1);

            player.Attack(monster);
            monster.Attack(player);

            Console.WriteLine($"Monster: {monster.CurrentHealth} / {monster.MaxHealth}");
            Console.WriteLine($"Player: {player.CurrentHealth} / {player.MaxHealth}");
        }
    }
}