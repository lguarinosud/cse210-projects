


using System.Reflection.Metadata.Ecma335; 
using System;

public class Word
{
    //Variables
    private string _text;
    private bool _isHidden;
    //private Random random = new Random();
    //Constructors

    public Word(string text)
        {
            _text = text;
            _isHidden = false;

        }

    //Methods
    public void Hide()
        {
            _isHidden = true;
            
        }

    public void Show()
        {
            _isHidden = false;
            string show_text = _text;
            
        }

    public bool isHidden()
        {
        if(_isHidden)
        {
            return true;
        }
        return false;
        }

    public string GetDisplayText() //will return just the word same amount of characters whether it is the word or the underscores
        {
            if(isHidden())
            {
               return _text = "________";
            }
            else
            {
                return _text;
            }
            
            
        }
}

  // string[] words = _text.Split(' ');
            //int _wordCount = words.Count();
            //int _randomNumber = random.Next(1, _wordCount);
            // string _underScore = "________";
            // while (words[_randomNumber] != _underScore)
            //     {
            //         words[_randomNumber] = _underScore;
            //     }