using System;

class Program
{
    static void Main(string[] args)
    {
        // make list
        List<Shape> shapes = new List<Shape>();
        // Make shapes
        Square shape1 = new Square("red", 4);
        Rectangle shape2 = new Rectangle("green", 4, 7);
        Circle shape3 = new Circle("blue", 4);
        // Add shapes to list
        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(shape3);

        // Iterate through list
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.bmGetColor());
            Console.WriteLine(shape.bmGetArea());
            Console.WriteLine();
        }
    }
}