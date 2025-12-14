using System;

class Program
{
    static void Main(string[] args)
    {
        
        
    // Create addresses    
    Address address1 = new Address("Anne St. #25238", "Provo", "Utah", "United States");
    Address address2 = new Address("Main St. #65677", "Providence", "Rhode Island", "United States");
    Address address3 = new Address("Main St. #15100", "Rexburg", "Idaho", "United States");

    // Create events

    Lecture lecture = new Lecture(
    "AI as Gamechanger for the world", 
    "Come and discover how AI is changing the world we live in",
    new DateOnly(2025,12,20),
    new TimeOnly(12,0),
    address1,
    new TimeOnly(11,00),
    "Mark Zuckerberg",
    20);

    Reception reception = new Reception(
    "First presidency visit", 
    "Come and get inspired with the first presidency of the church of Jesus Christ of Latter-day saints",
    new DateOnly(2025,12,30),
    new TimeOnly(10,0),
    address3,
    new TimeOnly(9,0),
    "ceremony.reception@premier.com");

    Outdoor outdoor = new Outdoor(
    "Community ready", 
    "Come and learn how to be ready in case of an earthquake",
    new DateOnly(2025,12,28),
    new TimeOnly(16,0),
    address2,
    new TimeOnly(15,30),
    "Rain expected");

    Console.WriteLine("\n==========================================================================");
    Console.WriteLine("                               LECTURE EVENT");
    Console.WriteLine("==========================================================================\n");
    lecture.StandardDetails();
    Console.WriteLine();
    lecture.FullDetails();
    lecture.ShortDescription();

    Console.WriteLine("\n==========================================================================");
    Console.WriteLine("                               RECEPTION EVENT");
    Console.WriteLine("==========================================================================\n");
    reception.StandardDetails();
    Console.WriteLine();
    reception.FullDetails();
    reception.ShortDescription();

    Console.WriteLine("\n==========================================================================");
    Console.WriteLine("                               OUTDOOR EVENT");
    Console.WriteLine("==========================================================================\n");
    outdoor.StandardDetails();
    Console.WriteLine();
    outdoor.FullDetails();
    outdoor.ShortDescription();


    }
}