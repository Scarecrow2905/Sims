namespace Sims;

public class Sims
{
    public GameManager gameManager;
    public BuildManager buildManager;
    public MenuManager menuManager;
    public FamilyManager familyManager;

    public Sims()
    {
        gameManager = new GameManager();
        buildManager = new BuildManager(this);
        menuManager = new MenuManager(this);
        familyManager = new FamilyManager();
    }
    
}