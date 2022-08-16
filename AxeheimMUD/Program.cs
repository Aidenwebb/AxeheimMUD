using AxeheimMUD.Models;
namespace AxeheimMUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room();

            foreach (Door door in room.Doors)
            {
                Console.WriteLine(door.Direction.ToString());
            }
            
        }
    }
}