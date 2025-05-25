using system;
{
    //job.cs
    public class Job
{
    //members variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void DisplayJobDetails()
    }

{
    Console.WriteLine($"{_company} {_jobTitle} {_startYear} {_endYear}");
}
    
}
    class Program
{
    static void Main(string[] args)
    {
        //create job objects
        Job job1 = new Job("Software Engineer", "Fab Tech", 2021, 2023);
        Job job2 = new Job("Senior Developer", "Amazon", 2023, 2024);

        //Display job details
        job1.DisplayJobDetails();
        job2.DisplayJobDetails();
    }
}