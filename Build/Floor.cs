namespace Sims;

public class Floor
{
    public string Name { get; set; }
    public List<Room> Rooms { get; set; }

    public Floor()
    {
        Name = Name;
        Rooms = new List<Room>();
    }
}