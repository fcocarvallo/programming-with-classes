using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade?: ");
        String grade_string = Console.ReadLine();
        int grade = int.Parse(grade_string);


        if (grade >= 90)
        {
            grade_string = "A";

        }

        else if (grade >= 80)
        {
            grade_string = "B";

        }
        else if (grade >= 70)
        {
            grade_string = "C";

        }
        else if (grade >= 60)
        {
            grade_string = "D";

        }
        else
        {
            grade_string = "F";
        }

        Console.WriteLine($"Your grade is {grade_string}");
        


    }
}