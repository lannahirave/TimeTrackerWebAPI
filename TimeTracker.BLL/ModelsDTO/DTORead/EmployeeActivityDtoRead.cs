namespace TimeTracker.BLL.ModelsDTO.DTORead;

public class EmployeeActivityDtoRead
{
    //contains all necessary fields to output information about an activity
    public int Id { get; set; }
    public DateTime Date { get; set; }

    public int ProjectId { get; set; }

    public int EmployeeId { get; set; }

    public int ActivityTypeId { get; set; }

    public int EmployeeRoleId { get; set; }
}