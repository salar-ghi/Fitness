namespace Infrastructure.Repositories;

public class ReadRepository<T> : IReadRepository<T> where T : class
{

    #region Ctor & Defenition
    private readonly FitnessContext _context;
    private readonly DbSet<T> _dbSet;

    public ReadRepository(FitnessContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }
    #endregion

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet
            .AsNoTracking()
            .ToListAsync()
            .ConfigureAwait(false);
    }

    public async Task<T> GetAsNoTracking<TIn>(TIn Id)
    {
        var result = await _dbSet
            .Include(x => x.Equals(Id))
            //.Where(x => x.Equals(Id))
            .FirstOrDefaultAsync()
            //.FindAsync(Id)
            .ConfigureAwait(false);
        return result;
    }

    public async Task<T> GetByIdAsync<TIn>(TIn Id)
    {
        var result = await _dbSet
            .FindAsync(Id)
            .ConfigureAwait(false);

        return result;
    }

    //public Task<IEnumerable<TEntity?>> FindAsync(Expression<Func<TEntity?, bool>> expression)
    //{
    //    throw new NotImplementedException();
    //}
}
