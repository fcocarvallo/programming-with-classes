class Cycling : Activity
{
    private double _speed;

    public Cycling(int length, DateOnly date, TimeOnly time, double speed): base(length, date, time)
    {
        _speed = speed;
    }

    // distance

    public override double CalculateDistance()
    {
        return GetSpeed() * (GetLength() / 60.0);
    }

    public double GetSpeed()
    {
        return _speed;
    }

    // speed(miles per hour)

    public override double CalculateSpeed()
    {
        return GetSpeed();
    }


}