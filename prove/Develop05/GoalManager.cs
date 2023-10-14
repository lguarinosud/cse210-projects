using System.ComponentModel;
using System.IO;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;


public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

   public int DisplayScore()
   {
    return _score;
   }
   
    public void Start()
    {
        //Console.WriteLine("Hello Develop05 World!");
        Console.Clear();
        
        Menu myMenu = new Menu();
        
        Goal mygoal =  new Goal();

        string points = mygoal.GetPoints();        
        while (true)
        {
            //Console.Clear();
            
            Console.WriteLine($"\nYou have {_score} points");
            Console.WriteLine("");
            myMenu.DisplayMenu();
            Console.WriteLine("");
            Console.Write("Select a choice from the menu: ");
            string resp = Console.ReadLine();

            switch(resp)
            {
                
                
                case "1": // Create a goal
                    Console.Clear();
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.WriteLine("  4. Return main manu");
                    Console.Write("What type of goal would you like to create? ");
                    string resp1 = Console.ReadLine();
                    CreateGoal(resp1);
                    Console.WriteLine("Goal succesfully recorded!");
                    Console.WriteLine("");
                    Console.WriteLine("Hit enter to return to the main menu...");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                
                case "2": // List Goals
                        
                        ListGoalDetails();
                        Console.WriteLine("Hit enter to return to the main menu...");
                        Console.ReadLine();
                        Console.Clear();

                    break;
                
                case "3": //save goals
                    SaveGoals();
                    Console.WriteLine("");
                    Console.WriteLine("Goals saved!");
                    Console.WriteLine("");
                    Console.WriteLine("Hit enter to return to the main menu...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "4": //Load goals
                    LoadGoals();
                    Console.WriteLine("Goals loaded, see below your goals: ");
                    ListGoalDetails();
                    Console.WriteLine("");
                    Console.WriteLine("Hit enter to return to the main menu...");
                    Console.ReadLine();
                    Console.Clear();

                    break;

                case "5": //record events
                    Console.WriteLine("The goals are: ");

                    DisplayGoalNames();

                    RecordEvent();
                    Console.WriteLine("");
                    Console.WriteLine("Event recorded!");
                    Console.WriteLine("");
                    Console.WriteLine("Hit enter to return to the main menu...");
                    Console.ReadLine();
                    Console.Clear();

                    

                    
                    
                    break;
                
                case "6": //quit
                    Console.WriteLine("I see you later!");
                    return;
            }

        }

    }
    
    public void DisplayPlayerInfo()
        {

        }  

    public void DisplayGoalNames()
    {
        int count = 0;
        foreach (Goal item in goals)
        {
            count++;
            string name = item.GetName();
            Console.WriteLine($"{count}. {name}");
        }
    }

    public void ListGoalDetails()
    {
        string check = "";
        int count = 0;
        foreach (Goal item in goals)
        {
            count++;
            
            // string name = item.GetName();
            // string description =  item.GetDescription();
            string goalDetail = item.GetDetailsString();
            if (item.isComplete())
            {
                check = "X";
            }
            else
            {
                check = " ";
            }
            //Console.WriteLine($"{count}. [{check}] {name} ({description})");
            Console.WriteLine($"{count}. [{check}] {goalDetail}");
        }
    }

    public void CreateGoal(string resp1)
    {
        
        string goalName;
        string goalDescription;
        string goalPoints;

        switch (resp1)
        {
            
            case "1": //simple goal
                Console.Write("What is the name of your goal? ");
                goalName = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associaed with this goal? ");
                goalPoints = Console.ReadLine();
                SimpleGoal simpleGoal_1 = new SimpleGoal(goalName, goalDescription, goalPoints);
                goals.Add(simpleGoal_1);
                break;

            case "2": // eternal goal
                Console.Write("What is the name of your goal? ");
                goalName = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associaed with this goal? ");
                goalPoints = Console.ReadLine();
                EternalGoal eternalGoal_1 = new EternalGoal(goalName, goalDescription, goalPoints);
                goals.Add(eternalGoal_1);
                break;

            case "3": //checklistgoal
                string target;
                string bonus; 
                Console.Write("What is the name of your goal? ");
                goalName = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associaed with this goal? ");
                goalPoints = Console.ReadLine();
                Console.Write("How many times does this goal needs to be acomplished for a bonus? ");
                target= Console.ReadLine();
                int targetInt = int.Parse(target);
                Console.Write("What is the bonus for accomplishing the target? ");
                bonus= Console.ReadLine();
                int bonusInt = int.Parse(bonus);
                CheckListGoal myCheckListGoal_1 = new CheckListGoal(goalName, goalDescription, goalPoints, targetInt, bonusInt);
                goals.Add(myCheckListGoal_1);
                break;
        }
    }

    public void RecordEvent()
    {
        Console.Write("Which Goal did you accomplish?: ");
        string resp2  = Console.ReadLine();
        int resp2Int = int.Parse(resp2);  
        int optionSelected = resp2Int -1;
        
        goals[optionSelected].RecordEvent();
        
        int points = int.Parse(goals[optionSelected].GetPoints());
        _score = points + _score; // add points to the score

        Console.WriteLine($"Congratulations! You have earned {points} points");
        Console.WriteLine("");
        Console.WriteLine($"You have now {_score} points");
        
       
    
    }

    public void SaveGoals()
    {
         Console.WriteLine("What's the filename? ");
        string resp = Console.ReadLine();
        string fileName = $"{resp}.csv";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            //outputFile.WriteLine("date, prompt, entry");
            
            // You can use the $ and include variables just like with Console.WriteLine
            outputFile.WriteLine(_score);
            foreach (Goal each in goals)
            {
                
                string line = each.GetStringRepresentation();

                outputFile.WriteLine(line);
                
            }
            
        }
    }

    public void LoadGoals()
    {
        Console.Write("What's the filename?: ");
        string resp = Console.ReadLine();
        string fileName = $"{resp}.csv";
        string[] lines = System.IO.File.ReadAllLines(fileName);


        for (int i = 0; i < lines.Length; i++)
        {
            if (i == 0)
                {
                    _score = int.Parse(lines[0]); // Assign a score to the first line  
                }
            
            string[] parts = lines[i].Split(",");
            string goalName;
            string goalDescription;
            string goalPoints;
            
            switch (parts[0])
            {
                
                case "SimpleGoal": //simple goal
                    goalName = parts[1];
                    goalDescription = parts[2];
                    goalPoints = parts[3];
                    string goalsIsComplete = parts[4];
                    bool goalIsCompleteBool = bool.Parse(goalsIsComplete);
                    SimpleGoal simpleGoal_1 = new SimpleGoal(goalName, goalDescription, goalPoints, goalIsCompleteBool);
                    goals.Add(simpleGoal_1);
                    break;

                case "EternalGoal": // eternal goal
                    goalName = parts[1];
                    goalDescription = parts[2];
                    goalPoints = parts[3];
                    EternalGoal eternalGoal_1 = new EternalGoal(goalName, goalDescription, goalPoints);
                    goals.Add(eternalGoal_1);
                    break;

                case "CheckListGoal": //checklistgoal
                    goalName = parts[1];
                    goalDescription = parts[2];
                    goalPoints = parts[3];
                    int goalAmountCompleted = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int goalBonus = int.Parse(parts[6]);
                    bool goalsIsComplete1 = bool.Parse(parts[7]);
                    CheckListGoal myCheckListGoal_1 = new CheckListGoal(goalName, goalDescription, goalPoints, goalAmountCompleted, target, goalBonus, goalsIsComplete1);
                    goals.Add(myCheckListGoal_1);
                    break;
                
                
                

                // Check if this is the first line
                
            }
    }
    }
}