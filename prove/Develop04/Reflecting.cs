public class Reflecting: Activity
{
    
    public Reflecting() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }


private string[] _reflectionQuestions = {
    "Think of a time when you overcame something difficult.~What helped you push through it?~How did you feel afterward?",
    "Think of a moment recently when you felt calm or grounded.~What created that moment?~How did it affect the rest of your day?",
    "Think of a time when someone showed you kindness.~What made that moment meaningful?~How did it change your perspective?",
    "Think of a time when you made a good decision.~What guided you in that moment?~What did you learn from the outcome?",
    "Think of a moment when you surprised yourself in a positive way.~What allowed that to happen?~How did it shift your confidence?",
    "Think of a time when you stayed patient during a challenge.~What helped you remain steady?~How did you feel once it was over?",
    "Think of a moment when you felt grateful.~What brought that feeling?~How did it influence your mindset afterward?",
    "Think of a time when you supported someone who needed you.~What motivated you to act?~How did that connection feel to you?",
    "Think of a moment when you handled stress better than expected.~What strategy worked?~How did it change your day?",
    "Think of a time when you felt connected with someone.~What created that connection?~How did that moment stay with you?",
    "Think of a moment when you chose growth instead of comfort.~What encouraged you to take that step?~How did it shape who you are now?",
    "Think of a time when you experienced peace or clarity.~What led to that feeling?~How did you carry that calm forward?",
    "Think of a moment when you let go of something heavy.~What made it possible?~How did you feel afterward?",
    "Think of a time when you started fresh or reset something in your life.~What inspired it?~How did the new beginning feel?",
    "Think of a moment when you trusted yourself fully.~What allowed you to do so?~How did the outcome reinforce your confidence?"
};


private string[] GetPrompts()
    {
        // Random random = new Random();
        // int position = random.Next(0, _reflectionQuestions.Length);
        // string selectedPrompt= _reflectionQuestions[position];
        string selectedPrompt = selectPrompt(_reflectionQuestions); 
        string[] parts = selectedPrompt.Split("~");
        return parts;

    }

public void ReflectingSession()
    {
        introduction();
        DateTime endTime = GetEndTime();

        do {
            string[] prompts = GetPrompts();

            Console.Clear();
            Console.WriteLine("Consider the following prompt: \n");
            Console.WriteLine($"**{prompts[0]}***");
            Console.WriteLine("\nWhen you have something in mind, press enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.Write($"{prompts[1]} ");
            CountDown(9);
            Console.WriteLine("✓");
            Console.Write($"{prompts[2]} ");
            CountDown(9);
            Console.WriteLine("✓");
            Thread.Sleep(2000);

        }while (DateTime.Now < endTime);

        conclusion();

    } 


}
