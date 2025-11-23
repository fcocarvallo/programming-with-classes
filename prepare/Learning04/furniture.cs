public class Sport
{
    public string _name;
    public string _type;

    public Sport(string name, string type)
    {
        _name = name;
        _type = type;
    }
}

public class Basketball : Sport
{
    public int _numberOfPlayers;

    public Basketball(string name, string type, int numberOfPlayers):base(name, type)
    {
        _name = name;
        _type = "Team Sport";
        _numberOfPlayers = numberOfPlayers;
    }

    public string GetSportInfo()
    {
        return $"Sport: {_name}, Type: {_type}, Number of Players: {_numberOfPlayers}";
    } 
}