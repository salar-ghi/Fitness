namespace Infrastructure.Repositories;

public class WriteRepository<T> : IWriteRepository<T> 
    where T : class 
{
    protected readonly FitnessContext _context;
    private DbSet<T> table =  null;

    public WriteRepository(FitnessContext context)
    {
        _context = context;
        table = _context.Set<T>();
    }

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
}
