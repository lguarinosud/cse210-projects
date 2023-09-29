

using System.Runtime.CompilerServices;

public class Reference
{

    //Variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //Constructors
    
    public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
        }

    public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = startVerse;
            _endVerse = endVerse;
        }

        //Methods
    public string GetDisplayText()
        {
            string text = $"{_book} {_chapter}: {_verse}";
            
            return text;
        }

}