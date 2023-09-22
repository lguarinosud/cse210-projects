

public class Menu
{
    public List<string> _menuItems = new List<string>()
    {

    "1. Write",
    "2. Display",
    "3. Load",
    "4. Save",
    "5. Quit"

    };

    public string DisplayMenu()
    {
        Console.WriteLine("\nPlease select one of the following options");
        
        foreach (string item in _menuItems)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("What would you like to do?");
        string optionSelected = Console.ReadLine();

        return optionSelected;
    
    }

}