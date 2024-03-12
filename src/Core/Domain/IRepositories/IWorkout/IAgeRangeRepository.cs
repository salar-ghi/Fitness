namespace Domain.IRepositories;

public interface IAgeRangeRepository : 
    IReadRepository<AgeRange>, 
    IWriteRepository<AgeRange>
{
}
