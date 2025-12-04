using System.Runtime.CompilerServices;

public class GoalManager
{
    private int _globalSum = 0;
    List<Goals> _myGoalList = new List<Goals>();

    public List<Goals> GetMyList()
    {
        return _myGoalList;
    }

    public void AddGoal(Goals myGoal)
    {
        _myGoalList.Add(myGoal);
        Console.WriteLine("Goal created successfully!");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Here is your listo of goals: ");
        List<Goals> goals = GetMyList();
        int n = 1;
        foreach (Goals goal in goals)
        {
            Console.Write($"{n}- ");
            goal.showGoal(); 
            n ++;
        }

    }

    public void UpdateGoal()
    {

        DisplayGoals();
        List<Goals> goals = GetMyList();
        Console.Write("What event would you like to record?: ");
        int selectedGoal = int.Parse(Console.ReadLine()) - 1;
        Goals goal = goals[selectedGoal];
        string[] parts = goal.GoalParts(goal.GetGoal());
        goal.updGoal(parts);
        SetTotal();
        Console.WriteLine();   
    }

    public void SetTotal()
    {
        
        foreach(Goals goal in _myGoalList)
        {
        
            int points = goal.TotalPoints();
            _globalSum = _globalSum + points;
           
        } 
    }

    public void SaveToFile()
    {
        
        Console.Write("How would you like to call your file?: ");
        string userFileName = Console.ReadLine()!;

        string filename = userFileName;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_globalSum);
            foreach (Goals goal in _myGoalList)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }

        }
        Console.WriteLine("\nFile saved successfully! ");
    }

    public void LoadFromFile()
    {
        Console.Write("Write the name of the file you want to load: ");
        string fileLoadFrom = Console.ReadLine()!;

        string filename = fileLoadFrom;

        string[] lines = System.IO.File.ReadAllLines(filename);


        foreach (string line in lines)
        {
            string[] parts = line.Split("~");
            if (parts.Length == 3)
            {
                Eternal etGoal = new Eternal(line);
                AddGoal(etGoal);

            }
            else if(parts.Length == 4)
            {
                string goalString = string.Join("~",parts[..3]);
                bool done = bool.Parse(parts[3]);

                Simple simGoal = new Simple(goalString, done);
                AddGoal(simGoal);


            }
            else if(parts.Length == 6)
            {
                string goalString = string.Join("~", parts);
                int timesDone = int.Parse(parts[5]);

                CheckList myCheckGoal = new CheckList(goalString, timesDone);
                AddGoal(myCheckGoal);
            }
            else
            {
                _globalSum = int.Parse(parts[0]);
            }
        }
        SetTotal(); 
        Console.WriteLine("\nFile loaded successfully!");
    }

    public void DisplayTotal()
    {
        Console.WriteLine($"Accumulated points: {_globalSum}\n");
    }

    public string GoalsCount()
    {
        int goalsCount = 0;
        int completedGoals = 0;
        foreach (Goals goal in _myGoalList)
        {
            if (goal.IsDone()){
            completedGoals ++;
            }
            goalsCount ++;
        }  
        return $"Your have registered {goalsCount} goals - completed: {completedGoals}.";
    }
       
}



