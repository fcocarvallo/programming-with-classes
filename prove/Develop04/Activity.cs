
using System.Data;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    private string[] _cheeringMessages = {
    "Great job — you invested in yourself today.",
    "Well done! Consistency builds strength.",
    "Nice work. Every step counts.",
    "You showed commitment — keep it up.",
    "Excellent effort. You're making real progress.",
    "Good work. Small actions lead to big results.",
    "You stayed focused — that matters.",
    "Impressive discipline. Keep going.",
    "You handled that beautifully.",
    "Strong work. You're moving in the right direction.",
    "You showed up, and that's what makes a difference.",
    "Great focus — you’re growing every day.",
    "Awesome! Hope you feel proud of that.",
    "Fantastic effort. You pushed through.",
    "You did something good for yourself today.",
    "That was solid work — well done.",
    "You're building a powerful habit. Keep going.",
    "Nice! You’re creating momentum.",
    "Great consistency — excellent session.",
    "You gave your best. That's what matters."
};

    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endTime = DateTime.Now;
    }

    private void SetDuration()
    {
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string duration = Console.ReadLine();
        int seconds = int.Parse(duration);
        _duration = seconds;
        _endTime = DateTime.Now.AddSeconds(seconds);
    }

    public int GetDuration()
    {   
        SetDuration();
        return _duration;
    }

    public DateTime GetEndTime()
    {
        return _endTime;
    }

    private void DisplayGreeting()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
    }

       public string selectPrompt(string[] prompts)
    {
        Random random = new Random();
        int position = random.Next(0, prompts.Length);
        return prompts[position];

    }

    private void DisplayAnimation()
    {

    DateTime endTime = DateTime.Now.AddSeconds(5);
    do{
        string[] c = ["/","-","\\","|"];

        foreach (string element in c)
        {
            Console.Write(element);
            Thread.Sleep(500);
            Console.Write("\b \b");

        }

    } while (DateTime.Now < endTime);
        
    }

    public void CountDown(int top)
    {

    do
    {
        Console.Write(top);
        Thread.Sleep(1000);
        top --;
        Console.Write("\b \b");

    } while (top > 0);

    }

    public void introduction()
    {
        Console.Clear();
        DisplayGreeting();
        int seconds = GetDuration();
        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        Console.WriteLine("Get ready! ...\n");
        DisplayAnimation();
    }

    public void conclusion()
    {
        Console.WriteLine();
        Console.WriteLine(selectPrompt(_cheeringMessages));
        DisplayAnimation();
        Console.WriteLine($"You have completed {_duration} seconds of {_name}.");
        DisplayAnimation();
        Console.Write("\nRedirecting you to the main menu, please wait ...");
        DisplayAnimation();
    }
}
