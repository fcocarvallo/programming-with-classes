using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello Sandbox World!");
        Circle myCircle = new Circle();
        myCircle.SetRadius(10.0);
        Console.WriteLine(myCircle.GetCircleArea());
    }
}   
