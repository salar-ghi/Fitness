namespace Domain.IRepositories;

public interface ILevelRepository : 
    IReadRepository<Models.Level>, 
    IWriteRepository<Models.Level>
{
}
