using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Software Engineer", "Microsoft", "2019", "2022");
        Job job2 = new Job("Manager", "Apple", "2022", "2023");

        Resume resume = new Resume("Allison Rose");
        resume.AddJob(job1);
        resume.AddJob(job2);

        resume.DisplayResume();
    }
}