
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    //constructor

    public ListingActivity(string name, string description, List<string> prompts) :base(name, description) 
    {
        _name = name;
        _description = description;
        _count =  0;
        _prompts = prompts;
        _duration = 20;
    }
    
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("get ready...");
        ShowSipnner(3);

        Console.WriteLine("List as many responses you can to the following prompt:");
        DisplayPrompt();
        
        Console.WriteLine("you may begin in:");
        ShowCountDown(3);
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while(DateTime.Now <= endTime)
        {
            GetListFromuser();
        }
        DisplayCounts();

    }

    public string GetRandomPrompt()
    {
        int rangeList = _prompts.Count();
        Random random = new Random();
        int ramdomPrompt = random.Next(0,rangeList);
        string selectedPrompt = _prompts[ramdomPrompt];

        return $"--- {selectedPrompt} ---";
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }

    public List<string> GetListFromuser()
    {
        _count++; 
        Console.Write(">");
        string resp = Console.ReadLine();
        _prompts.Add(resp);
        return _prompts;
        
    }

    public void DisplayCounts()
    {
        Console.WriteLine($"You listed {_count}!");
    }


}