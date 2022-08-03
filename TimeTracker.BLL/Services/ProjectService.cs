using TimeTracker.DAL.Repositories.Abstract;

namespace TimeTracker.BLL.Services;

public class ProjectService
{
    private readonly IProjectRepository _projectRepository;

    public  ProjectService(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }
}