using System.Reflection;
using Serilog;
using TimeTracker.BLL.MappingProfiles;
using TimeTracker.BLL.Services;
using TimeTracker.BLL.Services.Abstract;
using TimeTracker.DAL.Models;
using TimeTracker.DAL.Repositories;
using TimeTracker.DAL.Repositories.Abstract;

namespace TimeTracker.Extensions;

public static class BuilderServicesExtensions
{
    public static void RegisterCustomServices(this IServiceCollection services)
    {
        services.AddTransient<IProjectRepository, ProjectRepository>();
        services.AddTransient<ProjectBaseService, ProjectService>();
        services.AddTransient<IEmployeeActivity, EmployeeActivityRepository>();
        services.AddTransient<EmployeeActivityBaseService, EmployeeActivityService>();
    }

    public static void AddAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(cfg => { cfg.AddProfile<ProjectProfile>(); },
            Assembly.GetExecutingAssembly());
    }
    
    public static void AddLogger(this WebApplicationBuilder builder)
    {
        var logger = new LoggerConfiguration()
            .ReadFrom.Configuration(builder.Configuration)
            .Enrich.FromLogContext()
            .CreateLogger();
        builder.Logging.ClearProviders();
        builder.Logging.AddSerilog(logger);
    }
}