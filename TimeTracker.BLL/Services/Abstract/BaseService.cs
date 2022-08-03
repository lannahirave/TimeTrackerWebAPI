using AutoMapper;
using TimeTracker.DAL.Repositories.Abstract;

namespace TimeTracker.BLL.Services.Abstract;

public abstract class BaseService<T> where T: class
{
    protected readonly IRepository<T> Context;
    protected readonly IMapper Mapper;

    protected BaseService(IRepository<T> context, IMapper mapper)
    {
        Context = context;
        Mapper = mapper;
    }
}