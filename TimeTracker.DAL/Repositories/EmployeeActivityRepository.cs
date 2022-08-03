using Microsoft.EntityFrameworkCore;
using TimeTracker.DAL.Context;
using TimeTracker.DAL.Models;
using TimeTracker.DAL.Repositories.Abstract;

namespace TimeTracker.DAL.Repositories;

public class EmployeeActivityRepository : IEmployeeActivity
{
    private readonly TimeTrackerContext _context;

    public EmployeeActivityRepository(TimeTrackerContext context)
    {
        _context = context;
    }

    public async Task<EmployeeActivity?> GetEmployeeActivity(int id)
    {
        return await _context.Activities
            .Include(act => act.Employee)
            .Include(act => act.Project)
            .Include(act => act.ActivityType)
            .Include(act => act.EmployeeRole)
            .FirstOrDefaultAsync(act => act.Id == id);
    }

    public async Task<ICollection<EmployeeActivity>> GetEmployeeActivitiesByEmployeeId(int id)
    {
        return await _context.Activities
            .Include(act => act.Employee)
            .Include(act => act.Project)
            .Include(act => act.ActivityType)
            .Include(act => act.EmployeeRole)
            .Where(act => act.EmployeeId == id)
            .ToListAsync();
    }

    public async Task<ICollection<EmployeeActivity>> GetEmployeeActivitiesByEmployeeIdAndDate(int id, DateTime date)
    {
        var activities = await GetEmployeeActivitiesByEmployeeId(id);
        return activities.Where(act => act.Date.ToShortDateString() == date.Date.ToShortDateString()).ToList();
    }

    public async Task<ICollection<EmployeeActivity>> GetEmployeeActivitiesByEmployeeIdAndWeek(int id, int weekNumber)
    {
        var activities = await GetEmployeeActivitiesByEmployeeId(id);
        var result = activities
            .Where(act => DateIsInWeekNumber(act.Date, weekNumber))
            .ToList();
        return result;
    }

    private bool DateIsInWeekNumber(DateTime date, int weekNumber)
    {
        
        DateTime startOfTheYearDate = new DateTime(date.Year, 1, 1);
        var startOfTheWeek = startOfTheYearDate.AddDays((weekNumber-1) * 7).AddMilliseconds(1);
        
        var endOfTheWeek = startOfTheWeek.AddDays(7).AddMilliseconds(-1);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{startOfTheWeek} {endOfTheWeek} || {date}");
        
        Console.ForegroundColor = ConsoleColor.White;
        return date >= startOfTheWeek && date <= endOfTheWeek;
    }

    public Task<IEnumerable<EmployeeActivity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeActivity?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeActivity> CreateAsync(EmployeeActivity item)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeActivity> UpdateAsync(EmployeeActivity item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}