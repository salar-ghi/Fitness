namespace Domain.IRepositories;

public interface IReadRepository<TEntity>
{
    Task<TEntity> GetByIdAsync<TIn>(TIn Id);
    Task<IList<TEntity>> GetAllAsync();
    Task<TEntity> GetAsNoTracking<TIn>(TIn Id);
    //Task<IEnumerable<TEntity?>> FindAsync(Expression<Func<TEntity?, bool>> expression);

}
