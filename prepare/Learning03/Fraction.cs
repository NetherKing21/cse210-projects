public class Fraction
{
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

    //Member functions or methods
    //Getters and Setters
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

    //Getters but more specific
    public string GetFractionString()
    {
        string text = $"{GetTop()}/{GetBottom()}";
        return text;
    }
    public double GetDecimalValue()
    {
        double value = Convert.ToDouble(GetTop())/Convert.ToDouble(GetBottom());
        return value;
    }
}