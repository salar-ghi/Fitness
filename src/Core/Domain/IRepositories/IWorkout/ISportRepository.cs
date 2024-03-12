namespace Domain.IRepositories;

public interface ISportRepository : 
    IReadRepository<Sport>,
    IWriteRepository<Sport>
{
}
