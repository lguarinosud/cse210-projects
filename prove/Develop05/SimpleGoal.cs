


public class SimpleGoal : Goal
{
    
    private bool _iscomplete;


    public SimpleGoal(string name, string description, string points) :base (name, description,points)
    {
        _name = name;
        _description = description;
        _points = points;
        _iscomplete = false;

    }
    
    public SimpleGoal(string name, string description, string points, bool iscomplete) :base (name, description,points)
    {
        _name = name;
        _description = description;
        _points = points;
        _iscomplete = iscomplete;

    }


    public override void RecordEvent()
    {
        _iscomplete = true;
        
        
    }

    public override bool isComplete()
    {
        if (_iscomplete == false)
        {
            return false;
        }
        else 
        {
            return true;
        }
    }

    
    public override string GetStringRepresentation()
    {
        string saveGoal = $"SimpleGoal,{_name},{_description},{_points},{_iscomplete}";
        return saveGoal;
    }


}