
using System.Threading.Tasks.Dataflow;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    

    //Constructor

    public ReflectingActivity(string name, string description, List<string> prompts, List<string> questions) :base(name, description)
    {
        _name = name;
        _description = description;
        _prompts = prompts;
        _questions = questions;
        _duration = 20;
    }
    
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("get ready...");
        ShowSipnner(3);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");

        DisplayPrompt();
        Console.WriteLine("");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in:");
        ShowCountDown(3);
        
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while(DateTime.Now <= endTime)
        {
            DisplayQuestions();
            ShowSipnner(3);
        }




    }
    
    public string GetRandomPrompt()
    {
        int rangeList = _prompts.Count();
        Random random = new Random();
        int ramdomPrompt = random.Next(0,rangeList);
        string selectedPrompt = _prompts[ramdomPrompt];

        return $"--- {selectedPrompt} ---";
    }
    public string GetRandomQuestion()
    {
        int rangeList = _questions.Count();
        Random random = new Random();
        int ramdomQuestion = random.Next(0, rangeList);


        return $"> {_questions[ramdomQuestion]}";
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }

}
