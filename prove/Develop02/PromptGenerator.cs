
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    //Variables
    public List<string> _prompts = new List<string>()
    {

    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"

    };
    
    public void AddPrompt(string newPrommpt)
    {
        _prompts.Add(newPrommpt);
    }

    //Methods
    public string GetRamdomPrompt()
    {
        // Create a Random object
        Random random = new Random();

        // Generate a random index within the range of the list
        int randomIndex = random.Next(0, _prompts.Count);

        // Retrieve the randomly selected item
        string selectedItem = _prompts[randomIndex];
        
        return selectedItem;
    }
}