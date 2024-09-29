namespace Domain.IRepositories;

public interface IWriteRepository<T> 
    //where TEntity : class, new()
{
    Task CreateAsync(T entity);
    Task UpdateAsync<TId>(TId Id, T entity);
    Task DeleteAsync<TId>(TId Id);
}
