public class Circle: Shape
{
    private double _radius;

    // Constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Methods
    public override double bmGetArea()
    {
        double area = Math.PI * Math.Pow(_radius, 2);
        return area;
    }
}