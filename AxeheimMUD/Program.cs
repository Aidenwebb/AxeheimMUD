using AxeheimMUD.Models;
namespace AxeheimMUD
{
    internal class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            for (int i = 0; i < random.Next(100); i++)
            {
                rooms.Add(new Room());
            }

            foreach (Room room in rooms)
            {
                Console.WriteLine(room.DescribeRoom());
                Console.WriteLine(room.RoomId);
            }

            Player player = new Player();

            while (player.Health > 0)
            {
                // Prompt player to take an action
                player.PromptForAction();
                
            }


        }
    }
}