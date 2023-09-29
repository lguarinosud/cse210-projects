using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        
        while (true)
            {
        
                Console.WriteLine("Hello Develop03 World!");

                Reference myReference = new Reference("Ether", 12, 4 );

                Scripture myScripture = new Scripture(myReference, "Wherefore, whoso believeth in God might with surety hope for a better world, yea, even a place at the right hand of God, which hope cometh of faith, maketh an anchor to the souls of men, which would make them sure and steadfast, always abounding in good works, being led to glorify God.");

                
                // This will start by displaying "AAA" and waiting for the user to press the enter key
                Console.WriteLine(myScripture.GetDisplayText());

                Console.ReadLine();

                // This will clear the console
                Console.Clear();

                // This will show "BBB" in the console where "AAA" used to be
                Console.WriteLine(myScripture.GetDisplayText());

                

                if (myScripture.IscompletelyHidden() == true)
                {
                        break;
                   }

    
            }
    
    }


}