using TimeTracker.DAL.Models;

namespace TimeTracker.BLL.ModelsDTO.DTOWrite;

public class ActivityTypeDtoWrite
{
    //activity type (eg. Regular work, Overtime)
    public string Name { get; set; }
}