public class Simple: Goals
{
 
    public Simple(): base()
    {
    }

    public Simple(string goal, bool done): base(goal)
    {
        if (done)
        {
            SetDone();
        }
    }

    public override void showGoal()
    {
        string[] goal = GoalParts(GetGoal()); 
        if (IsDone())
        {
        Console.WriteLine($"[✓] {goal[0]} ({goal[1]})");
        }
        else
        {
        Console.WriteLine($"[ ] {goal[0]} ({goal[1]})");    
        }
    }

    public override void updGoal(string[] goalParts)
    {
        SetPoints(goalParts[2]);

        Console.WriteLine($"Awesome! You have scored {goalParts[2]}");
        SetDone();

    }

        public override string SaveGoal()
    {
        string goal = GetGoal();
        return $"{goal}~{IsDone()}";
    }





}



