using System.Reflection;
using TimeTracker.BLL.MappingProfiles;
using TimeTracker.BLL.Services;
using TimeTracker.BLL.Services.Abstract;
using TimeTracker.DAL.Repositories;
using TimeTracker.DAL.Repositories.Abstract;

namespace TimeTracker.Extensions;

public static class BuilderServicesExtensions
{
    public static void RegisterCustomServices(this IServiceCollection services)
    {
        services.AddTransient<IProjectRepository, ProjectRepository>();
        services.AddTransient<ProjectBaseService, ProjectService>();
    }
    
    public static void AddAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<ProjectProfile>();
            },
            Assembly.GetExecutingAssembly());
    }
}