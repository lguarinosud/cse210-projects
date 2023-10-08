

public class Menu
{
    private List<string> _options = new List<string>();
    
   
    public Menu ()
    {
        _options.Add("1. Start Breathing activity");
        _options.Add("2. Start reflecting activity");
        _options.Add("3. Start Listing activity");
        _options.Add("4. Quit");
    }

    public void DisplayMenu()
    {
        foreach (string option in _options)
        {
            Console.WriteLine(option);
        }
    }

   

}