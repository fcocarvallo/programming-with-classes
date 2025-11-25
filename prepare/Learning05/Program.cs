using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Circle("Yellow", 7));
        shapes.Add(new Rectangle("Red", 5, 2));
        shapes.Add(new Square("Blue", 4));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"{shape}\nColor: {color}, Area: {area}");
            Console.WriteLine();
            // Console.WriteLine(shape.GetColor());
            // Console.WriteLine(shape.GetArea());
        
    }
}

}