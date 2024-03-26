public class Rectangle : Shape
{
    private double _side1;
    private double _side2;

    // Constructor
    public Rectangle(string color, double side1, double side2) : base(color)
    {
        _side1 = side1;
        _side2 = side2;
    }

    // Methods
    public override double bmGetArea()
    {
        double area = _side1 * _side2;
        return area;
    }
}