using TimeTracker.DAL.Models;

namespace TimeTracker.BLL.ModelsDTO.DTOWrite;

public class EmployeeActivityDtoWrite
{
    //contains all necessary fields to output information about an activity
    public DateTime Date { get; set; }
    
    public int ProjectId { get; set; }
    
    public int EmployeeId { get; set; }
    
    public int ActivityTypeId { get; set; }
    
    public int EmployeeRoleId { get; set; }
}