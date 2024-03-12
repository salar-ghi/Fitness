namespace Infrastructure.Repositories;

public class ReadRepository<T> : IReadRepository<T> where T : class
{

    #region Ctor & Defenition
    protected readonly FitnessContext _context;
    private DbSet<T> table = null;

    public ReadRepository(FitnessContext context)
    {
        _context = context;
        table = _context.Set<T>();
    }
    #endregion

    public async Task<IList<T>> GetAllAsync()
    {
        return await table
            .AsNoTracking()
            .ToListAsync()
            .ConfigureAwait(false);
    }

    public async Task<T> GetAsNoTracking<TIn>(TIn Id)
    {
        var result = await table
            .Include(x => x.Equals(Id))
            //.Where(x => x.Equals(Id))
            .FirstOrDefaultAsync()
            //.FindAsync(Id)
            .ConfigureAwait(false);
        return result;
    }

    public async Task<T> GetByIdAsync<TIn>(TIn Id)
    {
        var result = await table
            .FindAsync(Id)
            .ConfigureAwait(false);

        return result;
    }

    //public Task<IEnumerable<TEntity?>> FindAsync(Expression<Func<TEntity?, bool>> expression)
    //{
    //    throw new NotImplementedException();
    //}
}
