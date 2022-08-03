using Microsoft.EntityFrameworkCore;
using TimeTracker.DAL.Context;
using TimeTracker.DAL.Models;
using TimeTracker.DAL.Repositories.Abstract;

namespace TimeTracker.DAL.Repositories;

public class ProjectRepository : IProjectRepository
{
    private readonly TimeTrackerContext _context;

    public ProjectRepository(TimeTrackerContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Project>> GetAllAsync()
    {
        return await _context.Projects.ToListAsync();
    }

    public async Task<Project?> GetByIdAsync(int id)
    {
        return await _context.Projects.FindAsync(id);
    }

    public async Task<Project> CreateAsync(Project item)
    {
        try
        {
            _context.Projects.Add(item);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return item;
    }

    public async Task<Project> UpdateAsync(Project item)
    {
        var project = await GetByIdAsync(item.Id);
        if (project is null) throw new Exception($"No object with id {item.Id} found");

        project.Name = item.Name;
        project.StartDate = item.StartDate;
        project.EndDate = item.EndDate;
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return project;
    }

    public async Task DeleteAsync(int id)
    {
        var project = await GetByIdAsync(id);
        if (project is null) throw new Exception($"No object with id {id} found");

        try
        {
            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}