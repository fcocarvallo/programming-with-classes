
class Circle
{
    private double _radius;

    public Circle()
    {
        Console.WriteLine("In the default constructor");
        _radius = 0.0;
    }

    public Circle(double radius)
    {
        Console.WriteLine("Not the default constructor");
        SetRadius(radius);
    }

    public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            Console.WriteLine("Radius cannot be negative.");
            _radius = 0;
        }
        else
        {
            _radius = radius;
        }
    }

    public double GetCircleArea()
    {
        return Math.PI * _radius * _radius;
    }

    public double GetCircunference()
    {
        return 2 * Math.PI * _radius;
    }

    public double GetDiameter()
    {
        return 2 * _radius;
    }

    


}