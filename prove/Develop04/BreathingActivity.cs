

using System.ComponentModel;

public class BreathingActivity : Activity
{
    //Constructor

    public BreathingActivity(string name, string description) :base(name, description)
    {
        _name = name;
        _description = description;
        _duration = 20;
        
        
    }
    
    public void Run()
    {
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.WriteLine("Get ready...");
        ShowSipnner(3);
        while (DateTime.Now <= endTime)
        {
        Console.Write("Breathe in...");
        ShowCountDown(3);
        Console.Write("\nBreathe out...");
        ShowCountDown(3);
        Console.WriteLine("");

        }
    }
}