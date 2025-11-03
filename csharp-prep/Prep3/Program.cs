using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int number = random.Next(100);
        int guess = 0;
        while (number != guess)
        {
            Console.WriteLine("What is your guess?: ");
            String number_string = Console.ReadLine();
            guess = int.Parse(number_string);
            if (number != guess)
            {
                Console.Write("Incorrect number. ");
                if (guess > number)
                {
                    Console.WriteLine("Try a lower one.");
                }
                else
                {
                    Console.WriteLine("Try a higher one.");
                }
            }
        }
        Console.WriteLine($"Yes! the number is {guess}! Well Done!");
    }

}