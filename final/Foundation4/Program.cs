using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates the list
        List<Activity> myActivities = new List<Activity>();

        // Creates running activity and adds it to the list
        Running running1 = new Running(30, new DateOnly(2025, 12, 03), new TimeOnly(15,0), 5);
        myActivities.Add(running1);

        // Creates cycling activity and adds it to the list
        Cycling cycling1 = new Cycling(30, new DateOnly(2025, 12, 04), new TimeOnly(10,0), 15);
        myActivities.Add(cycling1);

        // Creates swimming activity and adds it to the list
        Swimming swimming1 = new Swimming(25, new DateOnly(2025, 12, 05), new TimeOnly(12,0), 15);
        myActivities.Add(swimming1);


        // Displays results of activities
        foreach(Activity activity in myActivities)
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                           ACTIVITY");
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine(activity.DisplaySummary());
        }
        Console.WriteLine("------------------------------------------------------------------------------------------------");
        







    }
}