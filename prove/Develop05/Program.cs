using System;

class Program
{
    static void Main(string[] args)
    {
        Goals myGoal = new Goals();
        GoalManager myGoalList = new GoalManager();
        
        Menu myMenu = new Menu();
        myGoalList.DisplayTotal();
        int userInput = myMenu.DisplayMenu();

        

        do
        {
            
        if(userInput == 1)
        {
            int goalType = myGoal.GetGoalType();

            if (goalType == 3)
            {
                myGoal = new CheckList();

            }
            else if (goalType == 2)
            {
                myGoal = new Eternal();
            }
            else
            {
                myGoal = new Simple();
            }

            myGoal.SetGoal();
            myGoalList.AddGoal(myGoal);
            Console.WriteLine();

        }

        else if(userInput == 2)
            {
                myGoalList.DisplayGoals();
                Console.WriteLine();
            }

        else if(userInput == 3)
            {
                myGoalList.SaveToFile();
                Console.WriteLine();
            }

        else if(userInput == 4)
            {
                myGoalList.LoadFromFile();
                Console.WriteLine();
            }

        else if(userInput == 5)
            {
                myGoalList.UpdateGoal();
                Console.WriteLine();
            }

        myGoalList.DisplayTotal();
        userInput = myMenu.DisplayMenu();

        } while(userInput != 6);






        
    }
}