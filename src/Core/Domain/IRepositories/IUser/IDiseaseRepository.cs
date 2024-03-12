
namespace Domain.IRepositories;

public interface IDiseaseRepository : 
    IReadRepository<Disease>,
    IWriteRepository<Disease>
{
}
