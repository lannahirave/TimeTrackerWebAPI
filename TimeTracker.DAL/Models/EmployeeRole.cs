namespace TimeTracker.DAL.Models;

public class EmployeeRole
{
    //eg. Software Engineer, Business Analyst
    public EmployeeRole()
    {
        EmployeeActivities = new List<EmployeeActivity>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public ICollection<EmployeeActivity> EmployeeActivities { get; set; }
}