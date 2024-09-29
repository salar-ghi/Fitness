namespace Domain.IRepositories;

public interface IRepository<T>
{
    #region Read

    Task<T> GetByIdAsync<TIn>(TIn Id);
    Task<IEnumerable<T>> GetAllAsync();
    #endregion



    #region write
    Task CreateAsync(T entity);
    Task UpdateAsync<TId>(TId Id, T entity);
    Task DeleteAsync<TId>(TId Id);
    #endregion
}
