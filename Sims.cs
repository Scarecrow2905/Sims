using Sims.Build;

namespace Sims;

public class Sims
{
    public GameManager gameManager;
    public BuildManager buildManager;
    public FamilyManager familyManager;

    public Sims()
    {
        gameManager = new GameManager(this);
        buildManager = new BuildManager(this);
        familyManager = new FamilyManager();

        gameManager.MainMenu();
    }
    
}