using TimeTracker.DAL.Models;

namespace TimeTracker.BLL.ModelsDTO.DTORead;

public class EmployeeDtoRead
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public DateTime Birthday { get; set; }
    
}