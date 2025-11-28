using System;

class Program
{
    static void Main(string[] args)
    {

        
        Menu myMenu = new Menu();
        int userInput = myMenu.DisplayMenu();

        Goals myGoal = new Goals();
        GoalManager myGoalList = new GoalManager();

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

        }

        else if(userInput == 2)
            {
                myGoalList.DisplayGoals();
            }



        userInput = myMenu.DisplayMenu();

        } while(userInput != 6);






        
    }
}