


using System.Runtime.CompilerServices;

public class EternalGoal : Goal
{
    
    public EternalGoal(string name, string description, string points) : base (name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent()
    {
        
    }

    public override bool isComplete()
    {
        return false;
    }

    
    public override string GetStringRepresentation()
    {
        string saveGoal = $"EternalGoal,{_name},{_description},{_points}";
        return saveGoal;
    }



}