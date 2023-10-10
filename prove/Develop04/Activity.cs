
using System.ComponentModel;
using System.Threading.Tasks.Dataflow;
using System.Diagnostics;
using System.Data;
public class Activity
{
    //Variables
    protected string _name;
    protected string _description;
    protected int _duration;


    //Constructors
    public Activity()
    {
        _name = "default";
        _description = "default";
        _duration = 30;
    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        
    }
    //Methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity\n");
        Console.WriteLine(_description);
        Console.WriteLine("How Long in seconds, would you like for this session?");

        string duration_string = Console.ReadLine();
        int duration = int.Parse(duration_string);
        _duration = duration;
        

    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSipnner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.");
        ShowSipnner(3);
    }

    public void ShowSipnner(int seconds)
    {
       List<string> animationString = new List<string>();
       animationString.Add("|");
       animationString.Add("/");
       animationString.Add("-");
       animationString.Add("\\");
       animationString.Add("|");
       animationString.Add("-");
       animationString.Add("/");
       animationString.Add("-");
       animationString.Add("\\");
       DateTime startTime = DateTime.Now;
       DateTime endTime = startTime.AddSeconds(seconds);


       int i = 0;

       while (DateTime.Now < endTime)
       {
            Console.Write(animationString[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i >= animationString.Count())
            {
                i =0;
            }
       } 
    }

    public void ShowCountDown(int second)
    {
        for (int i=second; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


}