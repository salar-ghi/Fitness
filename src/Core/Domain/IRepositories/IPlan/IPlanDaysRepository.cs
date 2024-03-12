namespace Domain.IRepositories;

public interface IPlanDaysRepository : 
    IReadRepository<PlanDays>,
    IWriteRepository<PlanDays>
{
}
