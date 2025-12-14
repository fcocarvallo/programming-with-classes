public class Lecture: Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateOnly date, TimeOnly time, Address address, TimeOnly admission, string speaker, int capacity): base(title, description, date, time, address, admission)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($"Event type: {this.GetType().Name}");
        Console.WriteLine($"Speaker: {GetSpeaker()}");
        Console.WriteLine($"Capacity: {GetCapacity()}");
        Console.WriteLine();

    }

}
