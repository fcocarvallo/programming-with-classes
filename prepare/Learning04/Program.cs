using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Math("Froylan Sanchez", "Fractions", "5.1", "1-10");
        Console.WriteLine(assignment1.GetSummary());
        Math mathAssignment = (Math)assignment1;
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Assignment assignment2 = new Writing("Froylan Sanchez", "European History", "The Causes of World War II");
        Console.WriteLine(assignment2.GetSummary());
        Writing writingAssignment = (Writing)assignment2;
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}