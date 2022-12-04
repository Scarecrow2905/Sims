namespace Sims.Build;

public class BuildManager
{
    private readonly Sims _sims;
    public House House { get; set; }
    private List<Room> Rooms { get; set; }
    private List<Appliance> Appliances { get; set; }

    public BuildManager(Sims sims)
    {
        _sims = sims;

        House = new House(this);
        Rooms = new List<Room>();
        Rooms.Add(new Bathroom());
        Rooms.Add(new Bedroom());
        Rooms.Add(new Kitchen());
        Rooms.Add(new Livingroom());

        Appliances = new List<Appliance>();
        Appliances.Add(new Bed());
    }

    public void BuildMode()
    {
        Console.WriteLine("Entered build mode");
        PrintHouse();
        Console.ReadLine();
    }

    private void PrintHouse()
    {
        foreach (var room in Rooms)
        {
            Console.WriteLine($"{room.Id} {room.Type}");
        };
    }
}