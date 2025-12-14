class Running : Activity
{
    private double _distance;

    public Running(int length, DateOnly date, TimeOnly time, double distance): base(length, date, time)
    {
        _distance = distance;
    }

    // distance km
    public override double CalculateDistance()
    {
        return GetDistance();
    }

    public double GetDistance()
    {
        return _distance;
    }

    // speed(km per hour)

    public override double CalculateSpeed()
    {
        return GetDistance() / (GetLength() / 60.0);
    }


}