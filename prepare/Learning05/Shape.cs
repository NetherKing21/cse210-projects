public abstract class Shape
{
    protected string _color;

    // Constructor
    protected Shape(string color)
    {
        _color = color;
    }

    // Methods
    public string bmGetColor()
    {
        return _color;
    }

    public abstract double bmGetArea();
}