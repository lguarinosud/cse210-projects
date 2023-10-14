


using System.Security.Cryptography.X509Certificates;

public class Goal
{
    
    protected string _name;
    protected string _description;
    protected string _points;

     public Goal()
    {
        _name = "name";
        _description = "description";
        _points = "0";
    }
    
    public string GetPoints()
    {
        return _points;
    }
    
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    
     public Goal(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

      public virtual void RecordEvent()
    {
        
    }

    public virtual bool isComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        string goalDetail = $"{_name} ({_description})";
        return goalDetail;
    }

    public virtual string GetStringRepresentation()
    {
        
        return "";
    }

    // public abstract void RecordEvent();
  

    // public abstract bool isComplete();
    

    // public abstract string GetDetailsString();
    
    // public abstract string GetStringRepresentation();
    

  




}