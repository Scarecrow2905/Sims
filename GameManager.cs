namespace Sims;

public class GameManager
{
    private readonly Sims _sims;

    public GameManager(Sims sims)
    {
        _sims = sims;

    }

    public void MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Please enter an input: n/" +
                          "1: Build Mode n/" +
                          "2: Family Mode n/" +
                          "3: Play Mode");

        var choice = Console.ReadLine();

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



    }
    
    

}
