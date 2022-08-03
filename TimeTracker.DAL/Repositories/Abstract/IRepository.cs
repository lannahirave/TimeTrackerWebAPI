namespace TimeTracker.DAL.Repositories.Abstract;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task<T> CreateAsync(T item);
    Task<T> UpdateAsync(T item);
    Task DeleteAsync(int id);
}