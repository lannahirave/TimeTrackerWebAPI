using AutoMapper;
using TimeTracker.BLL.ModelsDTO.DTORead;
using TimeTracker.BLL.ModelsDTO.DTOWrite;
using TimeTracker.BLL.Services.Abstract;
using TimeTracker.DAL.Models;
using TimeTracker.DAL.Repositories.Abstract;

namespace TimeTracker.BLL.Services;

public class ProjectService : ProjectBaseService
{
    public ProjectService(IProjectRepository projectRepository, IMapper mapper) :
        base(projectRepository, mapper)
    {
    }

    public override async Task<ICollection<ProjectDtoRead>> GetProjectsAsync()
    {
        var projects = await Context.GetAllAsync();
        return Mapper.Map<ICollection<ProjectDtoRead>>(projects);
    }

    public override async Task<ProjectDtoRead> GetProjectByIdAsync(int id)
    {
        var project = await Context.GetByIdAsync(id)
                      ?? throw new Exception($"Project with id {id} not found");
        return Mapper.Map<ProjectDtoRead>(project);
    }

    public override async Task<ProjectDtoRead> CreateProjectAsync(ProjectDtoWrite projectDtoWrite)
    {
        var project = Mapper.Map<Project>(projectDtoWrite);
        var createdProject = await Context.CreateAsync(project);
        return Mapper.Map<ProjectDtoRead>(createdProject);
    }

    public override async Task<ProjectDtoRead> UpdateProjectAsync(ProjectDtoRead projectDtoRead)
    {
        var project = Mapper.Map<Project>(projectDtoRead);
        var updatedProject = await Context.UpdateAsync(project);
        return Mapper.Map<ProjectDtoRead>(updatedProject);
    }

    public override async Task DeleteProjectAsync(int id)
    {
        await Context.DeleteAsync(id);
    }
}