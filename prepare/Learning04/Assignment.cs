

public class Assignment
{
    protected string _studentName;
    protected string _topic;

    //Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"Student name: {_studentName} Topic: {_topic}";
    }


}

