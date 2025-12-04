using System.ComponentModel;

public class Goals{

    private string _goal;
    private int _points = 0;
    private int _timesDone = 0;

    private bool _done = false;

    public Goals()
    {
    }
    public Goals(string goal)
    {
        _goal = goal;
    }

    public int GetGoalType()
    {
        Console.WriteLine("What kind of goal would you like to create?: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select from the options above: ");
        string selection = Console.ReadLine();
        Console.WriteLine();
        int userSelection = int.Parse(selection);
        return userSelection;

    }

    public string GetTimesDone()
    {
        return _timesDone.ToString();
    }

    public string GetGoal()
    {
        return _goal;
    }
    public string GetBaseString()
    {
        Console.Write("Name of the goal: ");
        string goalName = Console.ReadLine();
        Console.Write("Enter a short description of the goal: ");
        string goalDescription = Console.ReadLine();
        Console.Write("How many points are associated to this goal?: ");
        string AssociatedPoints = Console.ReadLine();
        Console.WriteLine();
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

    
    public string[] GoalParts(string goal)
    {
        string[] goalParts = goal.Split("~");
        return goalParts;

    }

    public virtual void showGoal()
    {
        string[] goal = GoalParts(GetGoal()); 
        Console.WriteLine($"[ ] {goal[0]} ({goal[1]})");
    }

    public void addDone()
    {
        _timesDone ++;
    }

    public int TimesDone()
    {
        return _timesDone;
    }

    public bool IsDone()
    {
        return _done;
    }

    public void SetDone()
    {
        _done = true;
    }

    public void SetPoints(string stringNumber)
    {
        _points = 0;
        int intNumber = int.Parse(stringNumber);
        // _points = _points + intNumber;
        _points = intNumber;

    }

    public virtual void updGoal(string[] goalParts)
    {
    }
    public int TotalPoints()
    {
        int retValue = _points;
        _points = 0;
        return retValue;
    }

    public virtual string SaveGoal()
    {
        string goal = GetGoal();
        return goal;
    }


}