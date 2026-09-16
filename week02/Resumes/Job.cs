using System.Runtime.CompilerServices;

// step one start create a class name
public class Job
{
    // step two add member variables
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;
    public string _companyName = "";


    // step 3 create function
    public void DisplayInfo()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }
}