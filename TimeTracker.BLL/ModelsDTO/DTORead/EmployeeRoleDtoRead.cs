using TimeTracker.DAL.Models;

namespace TimeTracker.BLL.ModelsDTO.DTORead;

public class EmployeeRoleDtoRead
{
    //eg. Software Engineer, Business Analyst
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}