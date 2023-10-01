using System;
using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        
        while (true)
        {
            
            
            //tring _mainScripture = "Hola como te va, todo bien?";
            string _mainScripture = "For, behold, I have refined thee, I have chosen thee in the furnace of affliction.";
            
            Reference myReference = new Reference("1 Nephi", 20, 10 );

            Scripture myScripture = new Scripture(myReference, _mainScripture);


            while (myScripture.IscompletelyHidden() == false)   
            {
                // This will start by displaying "AAA" and waiting for the user to press the enter key
                Console.WriteLine(myScripture.GetDisplayText());

                myScripture.HideRandomWords();

                Console.WriteLine(" Press enter to continue or type quite to finish");

                string resp = Console.ReadLine();

                if(resp == "quit")
                {
                    break;
                }


                // This will clear the console
                Console.Clear();

                // This will show "BBB" in the console where "AAA" used to be
                //Console.WriteLine(myScripture.GetDisplayText());

            
            }

            Console.WriteLine("Have a good day!");
            break;  


        }
    
    }


}