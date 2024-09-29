namespace Infrastructure.Repositories;

public class WriteRepository<T> : IWriteRepository<T> 
    where T : class 
{
    protected readonly FitnessContext _context;
    private DbSet<T> _dbSet =  null;

    public WriteRepository(FitnessContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task CreateAsync(T entity) => await _dbSet.AddAsync(entity);

    public async Task UpdateAsync<TId>(TId Id, T entity) => _dbSet.Update(entity);

    public async Task DeleteAsync<TId>(TId Id)
    {
        var entity = await _dbSet.FindAsync(Id);
        if (entity != null) _dbSet.Remove(entity);
    }
}
