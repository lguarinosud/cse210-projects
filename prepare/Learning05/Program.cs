using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square mySquare = new Square("Blue", 3.00);
        Console.WriteLine($"Color: {mySquare.GetColor()}");
        Console.WriteLine($"Area: {mySquare.GetArea()}");
        Console.WriteLine("");

        Rectangule myRectangule = new Rectangule("Red",5 , 7);
        Console.WriteLine($"Color: {myRectangule.GetColor()}");
        Console.WriteLine($"Area: {myRectangule.GetArea()}");
        Console.WriteLine("");

        Circle myCircle = new Circle("Green", 2);
        Console.WriteLine($"Color: {myCircle.GetColor()}");
        Console.WriteLine($"Area: {myCircle.GetArea()}\n");


        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Yellow", 43));
        shapes.Add(new Rectangule("Blue", 4, 9));
        shapes.Add(new Circle("Black", 23));

        
        Console.WriteLine("From the list:");
        
        foreach (Shape item in shapes)
        {
            
            Console.WriteLine($"Color: {item.GetColor()}");
            Console.WriteLine($"Area:{item.GetArea()}\n");

        }
    

    
    }
}