namespace Domain.IRepositories;

public interface IAthleteInjuriesRepository : 
    IReadRepository<AthleteInjuries>,
    IWriteRepository<AthleteInjuries>
{
}
