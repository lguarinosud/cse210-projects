


using System.Reflection.Metadata.Ecma335;

public class Word
{
    //Variables
    private string _text;
    bool _isHidden;

    //Constructors

    public Word(string text)
        {
            _text = text;
        }

    //Methods
    public void Hide()
        {

        }

    public void Show()
        {

        }

    public bool isHidden()
        {
        return true;
        }

    public string GetDisplayText()
        {
            return "";
        }
}

