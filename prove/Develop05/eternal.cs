public class Eternal: Goals
{

    public Eternal(): base()
    {
    }
    public Eternal(string goal): base(goal)
    {
        
    }
   
    public override void updGoal(string[] goalParts)
    {
        SetPoints(goalParts[2]);
        Console.WriteLine($"Awesome! You have scored {goalParts[2]}");
    }
    
    


}