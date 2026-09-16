//  Create a class name for step one
public class Resume
{
    // step two add member variables
    public string _name = "";
    public List<Job> _jobs = new List<Job>();
    
    // step three create function 
    
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayInfo();
        }
    }

}