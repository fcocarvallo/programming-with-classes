abstract class Activity
{
    private int _length;
    private DateOnly _date;

    public Activity(int length, DateOnly date)
    {
        _length = length;
        _date = date;
    }

    public int GetLength()
    {
        return _length;
    }

    public DateOnly GetDate()
    {
        return _date;
    }

    public abstract double CalculateDistance();

    public abstract double CalculateSpeed();

    public double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }

    public string DisplaySummary()
    {
        string dateText = GetDate().ToString("dd MMM yyyy");
        string classType = GetType().Name;

        return $"{dateText} {classType} ({GetLength()} min): " +
            $"Distance {CalculateDistance():0.0} km, " +
            $"Speed {CalculateSpeed():0.0} kph, " +
            $"Pace {CalculatePace():0.0} min per km.";
    }
}