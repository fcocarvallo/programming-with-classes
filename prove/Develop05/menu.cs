
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

class Menu
{
    public int DisplayMenu()
    {
        int response = 0;

        while(response < 1 || response > 6) 
        {
            // Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create a new goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save goals");
            Console.WriteLine(" 4. Load goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Please, select an option from the menu above: ");

            try
            {
                response = int.Parse(Console.ReadLine()!);
            }
            catch 
            {
                Console.WriteLine("Input must be an integer value between 1 and 6.");
            }
        }

        return response;
    }
}