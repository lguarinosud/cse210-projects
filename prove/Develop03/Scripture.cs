


public class Scripture
{
    //Variables
    
    private Reference _reference;
    private string _text;
    
    private List<Word> wordList= new List<Word>();

    //Constructors

    public Scripture(Reference  Reference, string text)
        {
            _reference = Reference;
            _text = text;


        }

    //Methods
    public void HideRandomWords(int numberToHide)
        {
            
        }

    public string GetDisplayText()
        {
            string fullScripture = $"{_text}\n{_reference.GetDisplayText()}";
            return fullScripture;
        }

     public bool IscompletelyHidden()
        {
            
            if (GetDisplayText() == "")
                {   
                    return true;
                }
            return false;
        }


}
