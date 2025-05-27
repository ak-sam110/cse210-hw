using System;

//public class Resume
{
    public class Resume
{
    public string _name
//initialize the list
public List<Job> _jobs = new List<Job>();

    public void dispay()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("jobs:");

        //custom datatype
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
