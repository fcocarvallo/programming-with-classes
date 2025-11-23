using System.Threading;
public class BodyFeeling : Activity
{
    

public BodyFeeling() : base("Bodyfeeling", "This activity will help you relax by focusing on your different body parts to be mindful of this beautiful gift.")
    {
    }

public void BodyFeelingRoutine()
{
    
    introduction();
    DateTime endTime = GetEndTime();

    do
    {  
        Console.Write("Relax... ");
        CountDown(5);
        Console.Write("\nBreath in and out slowly... ");
        CountDown(5);
        Console.Write("\nNow, prepare... ");
        CountDown(5);
        Console.Clear();
        CountDown(5);
        Console.WriteLine();
        Console.Write("Feel your arms and hands... ");
        CountDown(8);
        Console.WriteLine("✓");
        Console.WriteLine();
        Console.Write("Feel you legs and feet... ");
        CountDown(8);
        Console.WriteLine("✓");
        Console.WriteLine();
        Console.Write("Now breath and focus on your head and neck... ");
        CountDown(8);
        Console.WriteLine("✓");
        Console.WriteLine();
        Console.Write("It is time for you back and shoulders... ");
        CountDown(8);
        Console.WriteLine("✓");
        Console.WriteLine();
        Console.Write("Finally breath deep and focus on your full body... ");
        CountDown(8);
        Console.WriteLine("✓");
        Console.WriteLine();
        Console.WriteLine();

    } while (DateTime.Now < endTime);

    conclusion();


}


}