using TimeTracker.DAL.Models;

namespace TimeTracker.DAL.Repositories.Abstract;

public interface IEmployeeActivity: IRepository<EmployeeActivity>
{
    public Task<EmployeeActivity?> GetEmployeeActivity(int id);
    public Task<ICollection<EmployeeActivity>> GetEmployeeActivitiesByEmployeeId(int id);
    
    public Task<ICollection<EmployeeActivity>> GetEmployeeActivitiesByEmployeeIdAndDate(int id, DateTime date);
    public Task<ICollection<EmployeeActivity>> GetEmployeeActivitiesByEmployeeIdAndWeek(int id, int weekNumber);
}