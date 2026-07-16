using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Student";
        job1._company = "BYU-Pathway";
        job1._startYear = 2024;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._jobTitle = "Freelancer";
        job2._company = "Self-Employed";
        job2._startYear = 2026;
        job2._endYear = 2027;

        Resume myResume = new Resume();
        myResume._name = "Janzent Grande Caliso";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}