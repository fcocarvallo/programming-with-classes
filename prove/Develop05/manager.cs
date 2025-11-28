public class GoalManager
{
    List<Goals> _myGoalList = new List<Goals>();


    // public GoalManager(List<Goals> myGoalList)
    // {
    //     _myGoalList = myGoalList;
    // }

    public List<Goals> GetMyList()
    {
        return _myGoalList;
    }

    public void AddGoal(Goals myGoal)
    {
        _myGoalList.Add(myGoal);
    }

    public void DisplayGoals()
    {
        List<Goals> goals = GetMyList();
        foreach (Goals goal in goals)
        {
            Console.WriteLine(goal.GetGoal()); 
        }
    }



}