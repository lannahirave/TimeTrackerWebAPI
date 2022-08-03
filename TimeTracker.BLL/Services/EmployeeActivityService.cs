using AutoMapper;
using TimeTracker.BLL.Services.Abstract;
using TimeTracker.DAL.Models;
using TimeTracker.DAL.Repositories.Abstract;

namespace TimeTracker.BLL.Services;

public class EmployeeActivityService: EmployeeActivityBaseService
{
    private readonly IEmployeeActivity Context;
    public EmployeeActivityService(IEmployeeActivity context, IMapper mapper) : base(context, mapper)
    {
        Context = context;
    }

    public override async Task<string> GetTimeTrackingByPersonIdAndDate(int personId, DateTime date)
    {
        var result = await Context.GetEmployeeActivitiesByEmployeeIdAndDate(personId, date);
        string review = CreateReview(result);
        return review;
    }

    public override async Task<string> GetTimeTrackingByPersonIdAndWeekNumber(int personId, int weekNumber)
    {
        var result = await Context.GetEmployeeActivitiesByEmployeeIdAndWeek(personId, weekNumber);
        string review = CreateReview(result);
        return review;
    }

    private string CreateReview(ICollection<EmployeeActivity> activities)
    {
        string review = "";
        if (!activities.Any())
        {
            return "No activities found.";
        }
        foreach (var item in activities)
        {
            review += item.ReviewOfActivity() + "\n";
        }
        return review;
    }
}