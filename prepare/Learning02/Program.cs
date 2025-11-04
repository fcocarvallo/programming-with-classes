using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._companyName = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2015;
        job1._endYear = 2020;


        Job job2 = new Job();
        job2._companyName = "Apple";
        job2._jobTitle = "Senior Developer";
        job2._startYear = 2020;
        job2._endYear = 2024;


        Resume person1 = new Resume();
        person1._name = "George Lucas";
        person1._jobs = new List<Job>();
        person1._jobs.Add(job1);
        person1._jobs.Add(job2);

        person1.DisplayResume();

    }

    public class Job
    {
        public string _companyName;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;

        public void DisplayJobInfo()
        {
            Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear} - {_endYear}");
        }

    }

    

    public class Resume
    {
        public string _name;
        public List<Job> _jobs;

        public void DisplayResume()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine();
            Console.WriteLine("Jobs:");
            foreach (Job job in _jobs)
            {
                job.DisplayJobInfo();
            }
        }
    }

}