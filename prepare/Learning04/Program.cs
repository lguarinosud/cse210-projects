using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment Assignment01 = new Assignment("Samuel Bennet", "Multiplication");
        string _summary1 = Assignment01.GetSummary();
        Console.WriteLine(_summary1);

        MathAssignment assignment2 = new MathAssignment("Roberto Rodriguez","Fractions", "7.3", "8-19");
        string _summary2 = assignment2.GetHomeWorkList();
        Console.WriteLine(_summary2);

        WritingAssignment assignment3 = new WritingAssignment("Mary Water", "European History", "The Causes of World War II by Mary Waters");
        string _summary3 = assignment3.GetWritingInformation();
        Console.WriteLine(_summary3);

    }
}

