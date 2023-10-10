



public class Rectangule : Shape
{
    
    private double _length;
    private double _width;
    public Rectangule(string color, double length, double width ) : base (color)
    {
        _color =  color;
        _length = length;
        _width =  width;
    }

    public override double GetArea()
    {
        
        double area =  _length * _width;
        return area;
    }


}