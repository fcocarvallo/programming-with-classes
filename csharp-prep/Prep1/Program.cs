using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you name?: ");
        string name = Console.ReadLine();
        Console.Write("And your last name?: ");
        string last_name = Console.ReadLine();
        Console.WriteLine($"Nice to meet you, {name}. {name} {last_name}");
    }
}