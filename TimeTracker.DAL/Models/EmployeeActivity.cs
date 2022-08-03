namespace TimeTracker.DAL.Models;

public class EmployeeActivity
{
    //contains all necessary fields to output information about an activity
    public int Id { get; set; }
    public DateTime Date { get; set; }

    public int ProjectId { get; set; }
    public Project Project { get; set; } = null!;

    public int EmployeeId { get; set; }
    public Employee Employee { get; set; } = null!;

    public int ActivityTypeId { get; set; }
    public ActivityType ActivityType { get; set; } = null!;

    public int EmployeeRoleId { get; set; }
    public EmployeeRole EmployeeRole { get; set; } = null!;
}