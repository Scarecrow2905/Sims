namespace Sims;

public class House
{
    private readonly BuildManager _buildManager;
    public List<Room> Rooms { get; set; }



    public House(BuildManager buildManager)
    {
        _buildManager = buildManager;
    }
    
}