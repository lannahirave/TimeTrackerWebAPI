using AutoMapper;
using TimeTracker.BLL.ModelsDTO.DTORead;
using TimeTracker.BLL.ModelsDTO.DTOWrite;
using TimeTracker.DAL.Models;

namespace TimeTracker.BLL.MappingProfiles;

public sealed class ProjectProfile : Profile
{
    public ProjectProfile()
    {
        CreateMap<Project, ProjectDtoRead>();

        CreateMap<ProjectDtoRead, Project>();

        CreateMap<ProjectDtoWrite, Project>();
    }
}