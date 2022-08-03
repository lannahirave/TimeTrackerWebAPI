namespace TimeTracker.BLL.ModelsDTO.DTORead;

public class EmployeeDtoRead
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Gender { get; set; } = null!;
    public DateTime Birthday { get; set; }
    
}