using System;

class Program
{
    static void Main(string[] args)
    {
        string repeat = "yes";

        while (repeat == "yes")
        {
            Console.Write("What is your guess number? Choose between 1 and 10: ");
            string guess = Console.ReadLine();
            int guess_int = int.Parse(guess); 

            //create the ramdon number
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);

            int attemps= 0;

            while (number != guess_int)
            {
                attemps++;
                if (guess_int < number)
                {
                    Console.Write("Higher\n");
                    Console.Write("What is your number? ");
                    guess = Console.ReadLine();
                    guess_int = int.Parse(guess); 
                }
                else
                {
                    Console.Write("Lower\n");
                    Console.Write("What is your number? ");
                    guess = Console.ReadLine();
                    guess_int = int.Parse(guess); 
                }
            }

        Console.Write($"You guessed it in {attemps} attemps!\n");
        Console.Write("Do you want to play again? yes/no : ");
        repeat = Console.ReadLine();

        }
    Console.Write("Thank you for playing \n");
    }
}