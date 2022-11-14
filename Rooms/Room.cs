namespace Sims;

public class Room
{
    public string Type { get; set; }
    public int Id { get; set; }
    public List<Appliance> Appliances { get; set; }

    public Room(string type, int id)
    {
        Type = type;
        Id = id;
    }
}