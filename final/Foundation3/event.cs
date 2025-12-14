using System.Runtime.InteropServices.Marshalling;

public class Event
{
    private string _title;
    private string _description;
    private DateOnly _date;
    private TimeOnly _time;

    private Address _address;
    private TimeOnly _admission;

    public Event(string title, string description, DateOnly date, TimeOnly time, Address address, TimeOnly admission)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _admission = admission;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDesc()
    {
        return _description;
    }

    public DateOnly GetDate()
    {
        return _date;
    }

    public TimeOnly GetTime()
    {
        return _time;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public TimeOnly GetAdmission()
    {
        return _admission;
    }

    public void StandardDetails()
    {
        
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Description: {GetDesc()}");
        Console.WriteLine($"Date: {GetDate()}");
        Console.WriteLine($"Time: {GetTime()}");
        Console.WriteLine($"Open from: {GetAdmission()}");
        Console.WriteLine($"Address: {GetAddress().ShowAddress()}");
    }

    public void ShortDescription()
    {
        Console.WriteLine($"Event: {this.GetType().Name}");
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Date: {GetDate()}");
        Console.WriteLine();
    }


}