using System.Collections.Generic;
public class Resume {
    private string _name;
    private List<Job> _jobs;

    public Resume(string name) {
        _name = name;
        _jobs = new List<Job>();
    }

    public string GetName() {
        return _name;
    }

    public void AddJob(Job job) {
        _jobs.Add(job);
    }

    public void DisplayResume() {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs) {
            job.DisplayJobDetail();
        }
    }
}