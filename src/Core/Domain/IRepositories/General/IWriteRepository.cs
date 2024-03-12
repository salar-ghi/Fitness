namespace Domain.IRepositories;

public interface IWriteRepository<TEntity> 
    //where TEntity : class, new()
{
    Task CreateAsync(TEntity entity);
    Task UpdateAsync<TId>(TId Id, TEntity entity);
    Task DeleteAsync(TEntity entity);
}
