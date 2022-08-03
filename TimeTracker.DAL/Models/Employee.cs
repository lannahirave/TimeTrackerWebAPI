namespace TimeTracker.DAL.Models;

public class Employee
{
    public Employee()
    {
        EmployeeActivities = new List<EmployeeActivity>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Gender { get; set; } = null!;
    public DateTime Birthday { get; set; }

    public ICollection<EmployeeActivity> EmployeeActivities { get; set; }
}