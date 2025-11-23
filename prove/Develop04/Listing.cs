public class Listing: Activity
{
    
    public Listing(): base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

string[] gratitudeListPrompts = {
    "What do you feel fortunate for today?",
    "List the people who have made your life better.",
    "What simple pleasures are you grateful for?",
    "Name the things in nature that you appreciate.",
    "What abilities or strengths are you thankful to have?",
    "List the comforts of your home that you value.",
    "What memories are you most grateful for?",
    "Name the foods and drinks that nourish and delight you.",
    "What aspects of your health are you thankful for?",
    "List the forms of entertainment that bring you joy.",
    "What opportunities are you grateful to have had?",
    "Name the personal qualities you appreciate in yourself.",
    "List the modern inventions you can't imagine life without.",
    "What acts of kindness have you received recently?",
    "Name the public spaces or services you are thankful for.",
    "List the things that made you smile this week.",
    "What lessons are you grateful to have learned?",
    "Name the animals that have touched your life.",
    "List the smells and sounds that make you feel content.",
    "What about your daily routine are you thankful for?"
};

    public void Listingsession()
    {
        introduction();

        DateTime endTime = GetEndTime();

        do{

            Console.WriteLine("List as many responses as you can to the following prompt:\n");
            Console.WriteLine(selectPrompt(gratitudeListPrompts));
            Console.WriteLine();
            Console.Write("You may begin in: ");
            CountDown(5);
            Console.WriteLine();
            Console.WriteLine();

            int seconds = 10;
            DateTime loopTimer = DateTime.Now.AddSeconds(seconds);
            int lisCount = 0;

            do
            {
                
                Console.Write("> ");
                Console.ReadLine();
                lisCount ++;
                
            } while (DateTime.Now < loopTimer);

            Console.WriteLine($"{lisCount} things you feel appreciation for. That's awesome!");
            Thread.Sleep(2500);
            


        } while (DateTime.Now < endTime);

        conclusion();



    }


}    

