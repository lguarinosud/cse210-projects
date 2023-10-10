



using System;
public class Circle : Shape
{
    
    private double _radious;
    public Circle(string color, double radious) : base (color)
    {
        _color =  color;
        _radious = radious;
    }

    public override double GetArea()
    {
        double pi = Math.PI;
        double area = pi * (_radious * _radious);
        return area;
    }


}