using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "BYU-Idaho";
        job1._jobTitle = "software Engineer";
        job1._startYear = 2009;
        job1._endyear = 2010;



        Job job2 = new Job();

        job2._company = "Ford";
        job2._jobTitle = "Marketing";
        job2._startYear = 2010;
        job2._endyear = 2024;


    

        Resume resume1 = new Resume();

        resume1._name = "Nicolas Hopkins";

        resume1._jobs.Add(job1);

        resume1._jobs.Add(job2);

        resume1.Display();

    }
}