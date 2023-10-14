public class Menu
{
    private List<string> _options = new List<string>();
    
   
    public Menu ()
    {
        _options.Add("   1. Create new Goal");
        _options.Add("   2. List Goals");
        _options.Add("   3. Save Goals");
        _options.Add("   4. Load Goals");
        _options.Add("   5. Record Event");
        _options.Add("   6. Quit");
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options");
        
        foreach (string option in _options)
        {
            Console.WriteLine(option);
        }
    }

   

}