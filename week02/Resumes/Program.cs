using System;
class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;   
}
    
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Fab Tech";
        job1._startYear = 2021;
        job1._endYear = 2023;

        Console.WriteLine("job1 company: Fab Tech");

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Amazon";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Console.WriteLine("job2 company: Amazon");

    }
}

