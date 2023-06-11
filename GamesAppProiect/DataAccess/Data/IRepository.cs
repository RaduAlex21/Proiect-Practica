namespace GamesAppProiect.DataAccess.Data;

public interface IRepository<T> where T : class
{
    Task<bool> DeleteAsync(T value);
    Task<T> FirstOrDefaultAsync(Func<T, bool> expression);
    Task<List<T>> GetAllAsync();
    Task<List<T>> GetEntitiesWhereAsync(Func<T, bool> expression);
    Task<T> InsertAsync(T value);
    Task<T> SearchByIdAsync(int id);
    Task<T?> UpdateAsync(T value);
}