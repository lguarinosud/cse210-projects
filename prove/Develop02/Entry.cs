

public class Entry
{
    //Variables
    public string _date;
    public string _promptText;
    public string _entryText;

    //Methods

    public void Display()
    {
        string entry = $"Date: {_date} - Prompt: {_promptText}\n{_entryText}";
        Console.WriteLine(entry);
    }

}