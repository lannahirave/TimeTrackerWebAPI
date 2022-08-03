namespace TimeTracker.DAL.Models;

public class ActivityType
{
    //activity type (eg. Regular work, Overtime)
    public int Id { get; set; }
    public string Name { get; set; }
    
    
    public ICollection<EmployeeActivity> EmployeeActivities { get; set; }
}