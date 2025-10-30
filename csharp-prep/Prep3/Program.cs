using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int number = random.Next(10);
        int guess = 0;
        while (number != guess)
        {
            Console.Write("What is your guess?: ");
            String number_string = Console.ReadLine();
            guess = int.Parse(number_string);
            if (number != guess)
            {
                Console.Write("Sorry, incorrect number. Try again!\n");
                if (guess > number)
                {
                    Console.Write("Try with a lower number\n");
                }
                else
                {
                    Console.Write("Try with a higher number\n");
                }
            }
        }
        Console.Write("Congratulations!, You guessed the number");
    }

}