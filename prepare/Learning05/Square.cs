public class Square : Shape
{
    private double _side;

    // Constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Methods
    public override double bmGetArea()
    {
        double area = _side * _side;
        return area;
    }
}