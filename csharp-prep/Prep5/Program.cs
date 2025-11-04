using System;
using System.Security.Cryptography;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numberString = Console.ReadLine();
        int number = int.Parse(numberString);
        return number;
    }

    static void PromptUserBirthYear(out int BirthYear)
    {
        Console.Write("Please enter your birth year: ");
        string birthYearString = Console.ReadLine();
        BirthYear = int.Parse(birthYearString);
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber, int birthYear)
    {
        int age = 2025 - birthYear;
        Console.WriteLine($"{name}, the square of your favorite number is {squaredNumber}.");
        Console.WriteLine($"{name}, You are turning {age} this year.");
    }
    

        
    static void Main(string[] args)
    {

        DisplayWelcome();
        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        int birthYear;
        PromptUserBirthYear(out birthYear);
        DisplayResult(name, squaredNumber, birthYear);

    }
}