public class CheckList: Goals
{

    public CheckList() : base()
    {
    }

    public CheckList(string goal, int timesDone): base(goal)
    {
        for (int i = 0; i < timesDone; i++)
        addDone();
    }

    public override string ComposeGoal()
    {
        string baseString = GetBaseString();
        Console.Write("How many times must complete the goal for a bonus?: ");
        string times = Console.ReadLine();
        Console.Write("points scored by getting the bonus?: ");
        string bonus = Console.ReadLine();
        return $"{baseString}~{bonus}~{times}~0";
    }

        public override void showGoal()
    {

        string[] goal = GoalParts(GetGoal()); 
        if (IsDone())
        {
        Console.WriteLine($"[✓] {goal[0]} ({goal[1]}) --- Completed {goal[4]}/{goal[4]}");
        }
        else
        {
        Console.WriteLine($"[ ] {goal[0]} ({goal[1]}) --- Completed {TimesDone()}/{goal[4]}");  
        }
    }

    public override void updGoal(string[] goalParts)
    {
        SetPoints(goalParts[2]);
        Console.WriteLine($"\nAwesome! You have scored {goalParts[2]} points");

        addDone();
        goalParts[5] = TimesDone().ToString();
        if (goalParts[4] == goalParts[5])
        {
            SetDone();
            int bonus = int.Parse(goalParts[3]);
            int act = int.Parse(goalParts[2]);
            string sum = (bonus + act).ToString();
            SetPoints(sum);
            Console.WriteLine($"You got the bonus of {goalParts[3]} points.");
        }
        
    }

    public override string SaveGoal()
    {
        string goal = GetGoal();
        goal = goal.Substring(0, goal.Length - 1);
        return $"{goal}{GetTimesDone()}";
    }



    
}