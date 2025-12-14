public class Outdoor: Event
{
    private string _forecast;

        public Outdoor(string title, string description, DateOnly date, TimeOnly time, Address address,TimeOnly admission, string forecast): base(title, description, date, time, address, admission)
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