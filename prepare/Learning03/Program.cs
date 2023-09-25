using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction myFraction1 = new Fraction();

        Fraction myFraction2 = new Fraction(5);

        Fraction myFraction3 = new Fraction(3, 4);
        
        Fraction myFraction4 = new Fraction(1, 3);

        Console.WriteLine("Hello Learning03 World!");

        myFraction1.Display();
        myFraction2.Display();
        myFraction3.Display();
        myFraction4.Display();


    }
}