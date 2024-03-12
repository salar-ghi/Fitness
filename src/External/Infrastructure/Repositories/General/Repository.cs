namespace Infrastructure.Repositories;

public class Repository<T> : IReadRepository<T>, IWriteRepository<T>
    where T : class
{

    #region Ctor & Defenition
    protected readonly FitnessContext _context;
    private DbSet<T> table = null;

    public Repository(FitnessContext context)
    {
        _context = context;
        table = _context.Set<T>();
    }
    #endregion


    // Write Queries
    #region Write Queries

    public async Task CreateAsync(T entity)
    {
        var res = await table.AddAsync(entity);
        await Save();
        //return await Task.FromResult(res.Entity);
    }

    public async Task UpdateAsync<TId>(TId Id, T entity)
    {
        var res = table.Update(entity);
        _context.Entry(entity).State = EntityState.Modified;
        //return await Task.FromResult(res.Entity);
    }

    public async Task DeleteAsync(T entity)
    {
        var res = table.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
    }

    public async Task Save()
    {
        await _context.SaveChangesAsync();
    }

    #endregion



    #region Read Queries

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

    #endregion

}
