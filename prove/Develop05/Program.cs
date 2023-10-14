using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        
        GoalManager myGoalManager = new GoalManager();

        
        myGoalManager.Start();
        


    }
}