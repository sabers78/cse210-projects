using System;

public class Resume
{
    public string _name;

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Your name: {_name}");
        Console.WriteLine("Past jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    } 
}