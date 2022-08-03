using AutoMapper;
using TimeTracker.BLL.ModelsDTO.DTORead;
using TimeTracker.BLL.ModelsDTO.DTOWrite;
using TimeTracker.DAL.Models;
using TimeTracker.DAL.Repositories.Abstract;

namespace TimeTracker.BLL.Services.Abstract;

public abstract class ProjectBaseService : BaseService<Project>
{
    protected ProjectBaseService(IRepository<Project> context, IMapper mapper) : base(context, mapper)
    {
    }

    public abstract Task<ICollection<ProjectDtoRead>> GetProjectsAsync();

    public abstract Task<ProjectDtoRead> GetProjectByIdAsync(int id);

    public abstract Task<ProjectDtoRead> CreateProjectAsync(ProjectDtoWrite project);

    public abstract Task<ProjectDtoRead> UpdateProjectAsync(ProjectDtoRead project);

    public abstract Task DeleteProjectAsync(int id);
}