class Program
{
    static void Main(string[] args)
    {
        Planet mercury = new Planet();
        mercury._name = "Mercury";
        mercury._diameter = 1234.343;
        mercury.DisplayPlanetInformation();

        Planet venus = new Planet();
        venus._name = "Venus";
        venus._diameter = 12353.234;
        venus.DisplayPlanetInformation();
    }
    
}