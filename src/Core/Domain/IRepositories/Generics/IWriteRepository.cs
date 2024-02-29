namespace Domain.IRepositories;

public interface IWriteRepository<TEntity> 
    where TEntity : class
{
    Task<object> CreateAsync(TEntity entity);
    Task<object> UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
}
