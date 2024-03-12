namespace Domain.IRepositories;

public interface IAthleteImgsRepository :
    IReadRepository<AthleteImgs>,
    IWriteRepository<AthleteImgs>
{
}
