class Swimming : Activity
{
    private int _laps;

    public Swimming(int length, DateOnly date, int laps): base(length, date)
    {
        _laps = laps;
    }

    // distance
    public override double CalculateDistance()
    {
        return GetLaps() * 50.0 / 1000.0;
    }

    public int GetLaps()
    {
        return _laps;
    }

    public override double CalculateSpeed()
    {
        return CalculateDistance() / (GetLength() / 60.0);
    }

    // speed(miles per hour)

    // public override double CalculateSpeed()
    // {
    //     return 60 / CalculatePace();
    // }

    // pace(minutes per mile/kilometer)

    // summary ex: 03 nov 2022 (30 min)- Distance 3.0 miles, Speed 6.0mph, Pace 10.0 min per mile
}