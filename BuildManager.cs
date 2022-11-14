namespace Sims;

public class BuildManager
{
    private readonly Sims _sims;
    private readonly MenuManager _menuManager;
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
    }

    public void BuildMode()
    {
        Console.WriteLine("Entered build mode");
        _menuManager.BuildMenu(); // Be wary about this one, might not work
    }

    private void PrintHouse()
    {
        foreach(var room in Rooms)
        { 
            Console.WriteLine($"{room.Id} {room.Type} ");
        };
    }
}