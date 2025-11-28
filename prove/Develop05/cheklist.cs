public class CheckList: Goals
{


    public override string ComposeGoal()
    {
        string baseString = GetBaseString();
        Console.WriteLine("How many time for a bonus?");
        string times = Console.ReadLine();
        Console.WriteLine("What is the bonus?");
        string bonus = Console.ReadLine();
        return $"{baseString}~{bonus}~{times}~0";
    }
    
}