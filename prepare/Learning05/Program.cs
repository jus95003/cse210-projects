using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();

        Square square = new Square("Blue", 8);
        shapeList.Add(square);

        Rectangle rectangle = new Rectangle("Green", 10, 5);
        shapeList.Add(rectangle);

        Circle circle = new Circle("Orange", 12);
        shapeList.Add(circle);

        foreach (Shape shape in shapeList)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}.");
        }
    }
}