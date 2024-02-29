namespace Domain.IRepositories;

public interface IReadRepository<TEntity>
{
    Task<TEntity> ReadAsync<TIn>(TIn Id);
    Task<IList<TEntity>> ReadAllAsync();
    Task<TEntity> GetAsNoTracking<TIn>(TIn Id);

}
