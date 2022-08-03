namespace TimeTracker.DAL.Models;

public class EmployeeRole
{
    //eg. Software Engineer, Business Analyst
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<EmployeeActivity> EmployeeActivities { get; set; }
}