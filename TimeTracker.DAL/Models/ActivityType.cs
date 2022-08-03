namespace TimeTracker.DAL.Models;

public class ActivityType
{
    //activity type (eg. Regular work, Overtime)
    public ActivityType()
    {
        EmployeeActivities = new List<EmployeeActivity>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = null!;


    public ICollection<EmployeeActivity> EmployeeActivities { get; set; }
}