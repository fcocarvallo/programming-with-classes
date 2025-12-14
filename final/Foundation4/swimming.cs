class Swimming : Activity
{
    private int _laps;

    public Swimming(int length, DateOnly date, TimeOnly time, int laps): base(length, date, time)
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


}