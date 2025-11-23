
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

class Menu
{
    public int DisplayMenu()
    {
        int response = 0;

        while(response < 1 || response > 5) 
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflecting Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Start Bodyfeeling Activity");
            Console.WriteLine(" 5. Quit");
            Console.Write("Please, select an option from the menu above: ");

            try
            {
                response = int.Parse(Console.ReadLine()!);
            }
            catch 
            {
                Console.WriteLine("Input must be an integer value between 1 and 5.");
            }
        }

        return response;
    }
}