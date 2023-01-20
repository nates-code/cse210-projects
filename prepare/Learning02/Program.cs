using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Head Engineer";
        job1._startYear = 2020;
        job1._endYear = 2080;
        job1.Display();
        
        
        Job Job2 = new Job();
        Job2._company = "Microsoft";
        Job2._jobTitle = "Head Engineer";
        Job2._startYear = 2007;
        Job2._endYear = 2023;
        Job2.Display();


        Resume myResume = new Resume();
        myResume._name = "Nathan";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.Display();

    }
}