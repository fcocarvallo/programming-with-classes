using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Threading;


class Program
{
    static void Main(string[] args)
    {
        
        Menu menu = new Menu();
        int userInput = menu.DisplayMenu();

        do
        {

            if (userInput == 1)
            {
                Breathing breath = new Breathing();

           
                breath.BreathInOut();
            }
            else if (userInput == 2)
            {
                Reflecting reflect = new Reflecting();

        
                reflect.ReflectingSession();
            }
            else if (userInput == 3)
            {
                Listing mylisting = new Listing();
                mylisting.Listingsession();
            }
            else if (userInput == 4)
            {
                BodyFeeling myBody = new BodyFeeling();
                myBody.BodyFeelingRoutine();
            }


            userInput = menu.DisplayMenu();

        } while (userInput != 5);   
         
    }
}

