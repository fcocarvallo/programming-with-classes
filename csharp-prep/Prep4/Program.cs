using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int x = -1;
        int sum = 0;
        int n = 0;
        int max = -99999999;

        do
        {
            Console.WriteLine("Enter the number you want to add to the list (0 to exit): ");
            String number_string = Console.ReadLine();
            x = int.Parse(number_string);
            if (x != 0)
            {
                numbers.Add(x);
                sum = sum + x;
                n++;

                if (x > max)
                {
                    max = x;
                }
            }

        

        } while (x != 0);

        if (numbers.Count > 0)
        {
            double average = (double)sum / n;
            Console.WriteLine("Adding complete.");
            Console.WriteLine("Summary of values:");
            Console.WriteLine("-------------------");
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The maximum is: {max}");
        }
        else
        {
            Console.WriteLine("The list is empty. Summary not available.");
        }

        Console.WriteLine();

    



    }
}