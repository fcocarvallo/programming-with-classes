class Cycling : Activity
{
    private double _speed;

    public Cycling(int length, DateOnly date, double speed): base(length, date)
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

    // pace(minutes per mile/kilometer)
    // public override double CalculatePace()
    // {
    //     return 60 / CalculateSpeed();
    // }

    // summary ex: 03 nov 2022 (30 min)- Distance 3.0 miles, Speed 6.0mph, Pace 10.0 min per mile

}