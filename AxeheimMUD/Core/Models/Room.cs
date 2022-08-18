namespace AxeheimMUD.Core.Models;

public class Room
{
    private Random _random = new Random();
    private static int _RoomCount = 0;
    public int Id { get; set; }
    public List<IMapObject> Contents = new List<IMapObject>();

    public Room()
    {
        Id = _RoomCount;
        _RoomCount++;
        _generateRoomContents();
    }

    private void _generateRoomContents()
    {
        Contents.Add(new Monster(_random.Next(1,Id+1), "monster", Id));
    }
}