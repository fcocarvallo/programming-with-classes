using System;
class Entry
{
    public DateTime _date;
    public string[] _menu = {

        "1. Write an entry",
        "2. Display entries",
        "3. Load a file",
        "4. Save entries",
        "5. Get inspired",
        "6. Quit"
    };

    public string[] _promptList =
{
        "Who made a positive impact on my day, even in a small way? ",
        "What is one kind thing I did for someone else today? ",
        "What do I need to forgive myself for? ",
        "What is something beautiful I noticed today that others might have missed? ",
        "What is one belief I have changed my mind about recently? ",
        "What part of my day would I like to relive, and what part would I rewrite? ",
        "What small actions can I take tomorrow to make life feel lighter?",
        "When did I feel closest to Christ this week? ",
        "What attribute of Christ am I currently trying to develop?",
        "What does it mean to me to “come unto Christ”? ",
        "What answers have I recently received from prayer? ",
        "How has God spoken to me in subtle ways recently? ",
        "What did I learn from the scriptures today, and how can I apply it?"
    };


    public void ShowMenu()
    {

        foreach (string item in _menu)
        {
            Console.WriteLine(item);
        }

    }

    public int UserSelection()
    {

        int selection = 0;

        do
        {
            Console.WriteLine("Please, select an option from the menu above:");
            string userInput = Console.ReadLine()!;
            selection = int.Parse(userInput);

        } while ((selection < 1) || (selection > 6));

        return selection;

    }

    public string[] SelectPrompt()
    {
        Random random = new Random();
        int number = random.Next(0, 12);
        string selectedPrompt = _promptList[number];
        Console.WriteLine(selectedPrompt);

        string entry = Console.ReadLine()!;

        return [selectedPrompt, entry]; 

    }

    public string ComposeEntry()
    {
        string[] prompOutput = SelectPrompt();
        string prompt = prompOutput[0];
        string userText = prompOutput[1];
        _date = DateTime.Now;
        string dateText = _date.ToShortDateString();

        return $"Date: {dateText}~Prompt: {prompt}~Entry: {userText}";
    }
    
}