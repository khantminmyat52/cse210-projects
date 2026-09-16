using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // Create object / instance 
        Job job1 = new Job();

        // add the information
        job1._jobTitle = "Software engineer";
        job1._companyName = "Microsoft";
        job1._endYear = 2022;
        job1._startYear = 2019;

        // call method
        job1.DisplayInfo();

        //  Create new object
        Job job2 = new Job();

        // add new information
        job2._jobTitle = "Manger";
        job2._companyName = "Apple";
        job2._endYear = 2023;
        job2._startYear = 2022;

        // call method
        job2.DisplayInfo();

        // create a resume object
        Resume resume1 = new Resume();

        // add information
        resume1._name = "Khant Min Myat";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // call method

        resume1.DisplayResume();
    }
}