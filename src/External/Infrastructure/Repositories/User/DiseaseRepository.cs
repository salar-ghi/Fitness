namespace Infrastructure.Repositories;

public class DiseaseRepository : Repository<Disease>, IDiseaseRepository
{
    #region Ctor & Definition
    public DiseaseRepository(FitnessContext context) : base(context) { }
    #endregion
}
