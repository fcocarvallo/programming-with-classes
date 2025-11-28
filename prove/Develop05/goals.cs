using System.ComponentModel;

public class Goals{

    private string _goal;
    private int points = 0;

    public int GetGoalType()
    {
        Console.WriteLine("What kind of goal would you like to create?: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string selection = Console.ReadLine();
        int userSelection = int.Parse(selection);
        return userSelection;

    }

    public string GetGoal()
    {
        return _goal;
    }

        public string GetBaseString()
    {
        Console.WriteLine("Name of the goal");
        string goalName = Console.ReadLine();
        Console.WriteLine("Enter a short description of the goal");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("How many points are associated to this goal?");
        string AssociatedPoints = Console.ReadLine();
        return $"{goalName}~{goalDescription}~{AssociatedPoints}";
    }

    public virtual string ComposeGoal()
    {
        return GetBaseString();
    }

    public void SetGoal()
    {
        string goal = ComposeGoal();
        _goal = goal;

    }

    // public void DisplayGoals(List<Goals> myGoals)
    // {
    //     foreach (Goals goal in myGoals)
    //     {
    //         Console.WriteLine(goal.GetGoal()); 
    //     }
    // }



}