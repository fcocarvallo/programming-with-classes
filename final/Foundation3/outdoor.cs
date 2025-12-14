public class Outdoor: Event
{
    private string _forecast;

        public Outdoor(string title, string description, DateOnly date, TimeOnly time, Address address, string forecast): base(title, description, date, time, address)
    {
        _forecast = forecast;
    }

    public string GetForecast()
    {
        return _forecast;
    }

        public void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($"Event type: {this.GetType().Name}");
        Console.WriteLine($"Forecast: {GetForecast()}");
        Console.WriteLine();
    }
}