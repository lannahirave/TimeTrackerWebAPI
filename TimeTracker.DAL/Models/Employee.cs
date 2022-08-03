namespace TimeTracker.DAL.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public DateTime Birthday { get; set; }
    
    public ICollection<EmployeeActivity> EmployeeActivities { get; set; }
}