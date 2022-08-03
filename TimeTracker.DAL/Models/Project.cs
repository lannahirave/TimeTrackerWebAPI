namespace TimeTracker.DAL.Models;

public class Project
{
    public Project()
    {
        EmployeeActivities = new List<EmployeeActivity>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    
    public ICollection<EmployeeActivity> EmployeeActivities { get; set; }
}