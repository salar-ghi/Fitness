namespace Infrastructure.Repositories;

public class Repository<T> : IRepository<T>
    where T : class
{

    #region Ctor & Defenition
    protected readonly FitnessContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(FitnessContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }
    #endregion


    // Write Queries
    #region Write Queries

    public async Task CreateAsync(T entity) => await _dbSet.AddAsync(entity);

    public async Task UpdateAsync<TId>(TId Id, T entity) => _dbSet.Update(entity);
    
    public async Task DeleteAsync<TId>(TId Id)
    {
        var entity = await GetByIdAsync(Id);
        if (entity != null) _dbSet.Remove(entity);
    }

    #endregion



    #region Read Queries

    public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync().ConfigureAwait(false);

    public async Task<T> GetByIdAsync<TIn>(TIn Id) => await _dbSet.FindAsync(Id);

    #endregion

}
