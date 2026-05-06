using System;
using System.Resources;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Macrosoft";
        job1._startYear = 1000;
        job1._endYear = 2023;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Data Engineer";
        job2._company = "Abble";
        job2._startYear = 9099;
        job2._endYear = 10020;
        job2.Display();

        Resume resume = new Resume();
        resume._name = "David";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();
    }
}