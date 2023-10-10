


using System.Drawing;

public class Shape
{
    protected string _color;

    //getters and setters

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color =  color;
    }

    public Shape(string color)
    {
        _color =  color;
    }

    public virtual double GetArea()
    {
        return 0.00;
    }
}