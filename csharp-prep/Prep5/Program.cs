using System;
using System.Globalization;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        // Your Main function should then call each of these functions saving the return values and passing data to them as necessary.

        
        welcomeMessage();

        string name = yourName();

        int favoNumber = favNumber();

        int squared = squaredNumber(favoNumber);

        string message = finalMessage(name, squared);

        Console.WriteLine(message);

        //DisplayWelcome - Displays the message, "Welcome to the Program!" 
        
        static string welcomeMessage()
            {
                string message = "Welcome to the Program!";
                return message;
            }
        
        //PromptUserName - Asks for and returns the user's name (as a string)

        static string yourName()
            {
                Console.WriteLine("What's your name? ");
                string name = Console.ReadLine();

                return name;
            }

        //PromptUserNumber - Asks for and returns the user's favorite number (as an integer)


        static int favNumber()
            {
                Console.WriteLine("What's your favourite number? ");
                string yourNumber = Console.ReadLine();
                int favoNumber = int.Parse(yourNumber);

                return favoNumber;
            }


        //SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)

        static int squaredNumber(int favoNumber)
            {
                int squared = favoNumber * favoNumber;

                return squared;
            }

        //DisplayResult - Accepts the user's name and the squared number and displays them.

        static string finalMessage(string name, int squaredNumber)
            {
             string squaredNumberString = squaredNumber.ToString();

             string message = $"{name}, the square of your number is {squaredNumberString}.";

             return message;

            }


    
    
    
    
    
    
    
    
    }
}