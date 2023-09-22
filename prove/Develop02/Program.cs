using System;

class Program
{
    static void Main(string[] args)
    {
        // Create new instance of the PromptGenerator
        PromptGenerator myPrompts = new PromptGenerator();

        //Create instance of the new menu
        Menu myMenu = new Menu();

        Journal myJournal = new Journal();
        
        while (true)
        {
            string optionSelected = myMenu.DisplayMenu();

            if (optionSelected == "1")
            {
                // Call the generator method ang get a ramdom prompt, then display it
                Entry myEntry = new Entry();
                
                // Make the question and store the response
                myEntry._promptText = myPrompts.GetRamdomPrompt();
                Console.WriteLine(myEntry._promptText);
                myEntry._entryText = Console.ReadLine();

                // Get the time
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                // Store the entry variable
                
                myEntry._date = dateText;

                // Add to the journey
                myJournal.AddEntry(myEntry);


            }



        else if (optionSelected =="2")
        {
            
            
            myJournal.DisplayAll();
        }
        else if (optionSelected =="3")
        {
            List<List<string>> _fileLoaded = myJournal.LoadFromFile();
            
            foreach (List<string> entry in _fileLoaded)
            {
              
                //Access the line [list, list, list]
                Entry myEntry = new Entry(); // Creates an abject of the Entry
                //Access  list [date, prompt, entry]
                
                
                //Assign a value to a variable
                string date = entry[0].ToString();
                string prompt = entry[1].ToString();
                string entryLoaded = entry[2].ToString();
                
                //Gives the values to the new entry
                myEntry._date = date;
                myEntry._promptText = prompt;
                myEntry._entryText = entryLoaded;
                
                //Add the entry to the journal
                    
                
                myJournal.AddEntry(myEntry);
            }
            

        }
        else if (optionSelected =="4")
        {
            myJournal.SaveToFile();
        }
        else if (optionSelected =="5")
        {
            break;
        }

        else
        {
            break;
        }
    





        
        
        

        

        }
    }
}