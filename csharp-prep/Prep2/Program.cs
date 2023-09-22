using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        
        while (true)
        {
            string grade = "0";
            Console.WriteLine(grade);
            Console.WriteLine("What is your grade?");
            grade = Console.ReadLine();
            int grade_int = int.Parse(grade);
            string grade_letter;
            
            if (grade_int >= 90)
            {
                grade_letter = "A";
            }
            else if (grade_int >= 80 && grade_int <= 89)
            {
                grade_letter = "B";
                
            }
            else if (grade_int >= 70 && grade_int <= 79)
            {
                grade_letter = "C";
            }
            else if (grade_int >= 60 && grade_int <= 69)
            {
                grade_letter = "D";
            }
            else if (grade_int <= 59)
            {
                grade_letter = "F";
            }
            else
            {
                Console.WriteLine("Your Input needs to be between 1 and 100");
                
                Console.WriteLine("Do you have another grade? Enter y/n");
                string resp = Console.ReadLine();
                if (resp == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Thank you!");
                    break;
                }
            }

            Console.WriteLine($"Your grade is {grade_letter}");

            if (grade_int >=70)
            {
                Console.WriteLine("Congratulation, you approved!");
            }
            else
            {Console.WriteLine("Try next one");
            }

            string response = "";
                Console.WriteLine("Do you have another grade?");
                response = Console.ReadLine();
                if (response == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }

}        
    }
}