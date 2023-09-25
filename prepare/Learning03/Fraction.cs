
using System.Dynamic;

public class Fraction
{
    // Atributes
    private int _top;
    private int _bottom;

    //Constructors
    public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

    public Fraction(int wholeNumber)
        {
            _top = wholeNumber;
            _bottom = 1;
        }

    public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }

    //Methods

    public int GetTop()
        {

            return _top;
        }

    public void SetTop(int top)
        {

            _top = top;

        }

    public int GetBottom()
        {

            return _bottom;
        }

    public void SetBottom(int bottom)
        {

            _bottom = bottom;
        }

    private string GetFractionString()
        {

            string newFraction = $"{_top}/{_bottom}";
            
            return newFraction;
        }

    private double GetDecimalValue()
        {

            return (double)_top / (double)_bottom;
        }

    public void Display()
        {

            string fractionString = GetFractionString();
            double decimalDouble = GetDecimalValue();

           
            Console.WriteLine(fractionString);
            Console.WriteLine(decimalDouble);
        }

         
            

}


