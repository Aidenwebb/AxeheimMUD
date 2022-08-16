using AxeheimMUD.Models;
namespace AxeheimMUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Room room = new Room();

            Console.WriteLine(room.DescribeRoom());
            
            
        }
    }
}