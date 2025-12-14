public class Reception: Event
{
    private string _rsvp;

    public Reception(string title, string description, DateOnly date, TimeOnly time, Address address, string rsvp): base(title, description, date, time, address)
    {
        _rsvp = rsvp;
    }

    public string GetRsvp()
    {
        return _rsvp;
    }

    public void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($"Event type: {this.GetType().Name}");
        Console.WriteLine($"RSVP: {GetRsvp()}");
        Console.WriteLine();
    }
}