
using System;
using System.ComponentModel;


public class Scripture
{
    //Variables
    
    private Reference _reference;
    
    public List<Word> wordListObj= new List<Word>();

    //Constructors

    public Scripture(Reference  Reference, string text)
        {
           
           _reference = Reference;

           string[] wordsList = text.Split(' ');

           //Converting a list of string into a list of obj Word
            wordListObj = wordsList.Select(word => new Word(word)).ToList();
            
        }

    //Methods
    public void HideRandomWords()
        {
            
            //List<int> ramdomNumbers = new List<int>();
            Random random = new Random();
            int _wordCount = wordListObj.Count();
            int numberToHide = random.Next(0, _wordCount);

            
            
            Word theWordObj = wordListObj[numberToHide];
            
            if (theWordObj.isHidden()== false)
            {
                theWordObj.Hide();
            }
            else
            {
                while (true)
                {
                
                    {
                     numberToHide = random.Next(0, _wordCount);
                     theWordObj = wordListObj[numberToHide];
                    if(!theWordObj.isHidden())
                      {
                        theWordObj.Hide();
                        break;
                      }
                    }
                    
                    
                    
                }

                
            }
            

            
            // while (theWordObj.isHidden())
            // {
            //     bool containsTarget = ramdomNumbers.Contains(numberToHide);
            //     if(containsTarget)
            //     {
            //     int _randomNumber = random.Next(0, _wordCount);
            //     theWordObj = wordListObj[_randomNumber];
            //     }
            //     else
            //     {
            //         wordListObj[numberToHide].Hide();
            //         ramdomNumbers.Add(numberToHide);
            //         break;
            //     }
           // }
            
        }

    public string GetDisplayText()
        {
            string _sentence;
            string _referenceString = _reference.GetDisplayText();
            string _fullScripture;
            List<String> toStringList = new List<string>();
            foreach (Word item in wordListObj)
            {
                toStringList.Add(item.GetDisplayText());
            }
            
            _sentence = string.Join(" ", toStringList);

            _fullScripture = $"{_sentence}\n{_referenceString}";
            return _fullScripture;
        }

    public bool IscompletelyHidden()
    {
        bool _boolean = true; // Initialize _boolean to false
        
        foreach (Word item in wordListObj)
        {
            if (!item.isHidden())
            {
                _boolean = false; // If any item is hidden, set _boolean to true
                break; // Exit the loop early since we found a hidden item
            }
        }

        return _boolean; // Return true if no item is hidden, false if any item is hidden
    }
            
            
    


}
