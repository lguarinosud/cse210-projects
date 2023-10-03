


public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    //Constructor

    public MathAssignment(string studentName, string topic, string textBookSection, string problem) : base(studentName, topic)
    {

        _textBookSection = textBookSection;
        _problems = problem;
    }

    //methods

    public string GetHomeWorkList()
    {
        return $"Student name: {_studentName} - Topic: {_topic}\nTextBoookSection: {_textBookSection} - Problem: {_problems}";
        
    }


}