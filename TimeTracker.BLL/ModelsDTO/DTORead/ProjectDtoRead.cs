namespace TimeTracker.BLL.ModelsDTO.DTORead;

public class ProjectDtoRead
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}