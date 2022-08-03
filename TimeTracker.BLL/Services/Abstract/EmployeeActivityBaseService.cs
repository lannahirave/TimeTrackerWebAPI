using AutoMapper;
using TimeTracker.DAL.Models;
using TimeTracker.DAL.Repositories.Abstract;

namespace TimeTracker.BLL.Services.Abstract;

public abstract class EmployeeActivityBaseService: BaseService<EmployeeActivity>
{
    protected EmployeeActivityBaseService(IRepository<EmployeeActivity> context, IMapper mapper) : base(context, mapper)
    {
    }

    public abstract Task<string> GetTimeTrackingByPersonIdAndDate(int personId, DateTime date);
    public abstract Task<string> GetTimeTrackingByPersonIdAndWeekNumber(int personId, int weekNumber);
}