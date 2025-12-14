class Running : Activity
{
    private double _distance;

    public Running(int length, DateOnly date, double distance): base(length, date)
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

    // pace(minutes per mile/kilometer)

    // public override double CalculatePace()
    // {
    //     return 60 / CalculateSpeed();
    // }

    // summary ex: 03 nov 2022 (30 min)- Distance 3.0 miles, Speed 6.0mph, Pace 10.0 min per mile

}