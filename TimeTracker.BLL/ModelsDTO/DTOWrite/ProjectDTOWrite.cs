namespace TimeTracker.BLL.ModelsDTO.DTOWrite;

public class ProjectDtoWrite
{
    public string Name { get; set; } = null!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}