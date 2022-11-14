namespace Sims;

public class MenuManager
{
    private readonly Sims _sims;
    public BuildManager BuildManager;

    public MenuManager(Sims sims)
    {
        _sims = sims;
        
    }

    public void MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Please enter an input: /n" +
                          "1: Build Mode /n" +
                          "2: Family Mode /n" +
                          "3: Play Mode");

        var choice = Console.ReadLine();
        bool menuActive = true;
        while (menuActive)
        {
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    _sims.buildManager.BuildMode();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Entered Family mode");
                    // sims.familyManager.FamilyMode();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Entered play mode");
                    // sims.gameManager.PlayMode();
                    break;
            }

            menuActive = false;
        }
    }

    public void BuildMenu()
    {
        var choice = Console.ReadLine();
        bool menuActive = true;
        while (menuActive)
        {
            switch (choice)
            {
                case "1":
                    Console.WriteLine("1: Build rooms in the house");
                    
                    break;
                case "2":
                    Console.WriteLine("2: Show available rooms");
                    break;
            }

            menuActive = false;
        }
    }
}