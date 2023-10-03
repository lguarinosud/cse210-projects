


public class WritingAssignment : Assignment
{
    string _title;
    

    //Constructors

    public WritingAssignment(string studentName, string topic, string title) :base(studentName, topic)
    {
        _studentName   = studentName;
        _topic = topic;
        _title = title;
    }


    //methods

    public string GetWritingInformation()
    {
        return $"Student name: {_studentName} - Topic: {_topic}\ntitle: {_title}";
    }

}