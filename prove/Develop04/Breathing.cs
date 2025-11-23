using System.Threading;
public class Breathing : Activity
{
    

public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

public void BreathInOut()
{
    
    introduction();
    DateTime endTime = GetEndTime();

    do
    {
        Console.Write("Breath In ");
        CountDown(5);
        Console.WriteLine("✓");
        Console.WriteLine();
        Console.Write("Breath Out ");
        CountDown(5);
        Console.WriteLine("✓");
        Console.WriteLine();
        Console.WriteLine();

    } while (DateTime.Now < endTime);

    conclusion();


}


}