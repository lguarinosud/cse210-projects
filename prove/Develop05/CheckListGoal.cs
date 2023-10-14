


public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private bool _iscomplete;
    private int _target;
    private int _bonus;


    public CheckListGoal(string name, string description, string points, int target, int bonus) : base (name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
        _iscomplete = false;

    }

    public CheckListGoal(string name, string description, string points, int amountCompleted, int target, int bonus, bool isComplete) : base (name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
        _iscomplete = isComplete;

    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            Console.WriteLine(_points, _bonus);
            int result = int.Parse(_points) + _bonus;
            _points = result.ToString();
            
        }
        
    }

    public override bool isComplete()
    {
        if (_amountCompleted == _target)
        {
            _iscomplete = true;
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public override string GetDetailsString()
    {
        string goalDetail = $"{_name} ({_description}), -- Currently completed: {_amountCompleted}/{_target}";
        return goalDetail;
    }

    public override string GetStringRepresentation()
    {
        string saveGoal = $"CheckListGoal,{_name},{_description},{_points},{_amountCompleted},{_target},{_bonus},{_iscomplete}";
        return saveGoal;
    }




}