namespace Domain.IRepositories;

public interface IReadRepository<T>
{
    Task<T> GetByIdAsync<TIn>(TIn Id);
    Task<IEnumerable<T>> GetAllAsync();
}
