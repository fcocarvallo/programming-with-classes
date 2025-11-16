using System;
using System.Diagnostics;
using System.Net.Quic;
using System.Threading.Tasks.Dataflow;
class Program
{
    
    static void Main(string[] args)
    {
        
        Library quote = new Library();
        quote.SetScripture();

        Scripture myScripture = new Scripture(quote.GetScriptureText());
        string userInput;

        string[] parameters = quote.GetRefParameters();
        Reference myReference;
        Console.Clear();

        if (parameters.Length == 4)
        {
            myReference = new Reference(parameters[0], parameters[1], parameters[2], parameters[3]); 
        }
        else
        {
            myReference = new Reference(parameters[0], parameters[1], parameters[2]);
        }
        
        int iteration = 0;
      
        myReference.DisplayReference();
        Console.WriteLine();
        myScripture.ShowText();

        do
        { 
            if (iteration != 0)
            {
        
                if(iteration == 6)
                {
                    myScripture.ForceHide();
                }
            myScripture.ChangeStatus();
            myReference.DisplayReference();
            Console.WriteLine();
            myScripture.ShowList(); 

            }
            Console.Write($"\nIteration {iteration}/6");
            Console.Write("\nPress enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine()!;
            iteration = iteration + 1;
            Console.Clear();
            

        } while (userInput != "quit" && iteration < 7);



    } 
    
}   
