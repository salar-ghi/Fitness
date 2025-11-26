namespace Infrastructure.Services;

public class PlanGeneratingService
{
    private readonly FitnessContext _context;

    public PlanGeneratingService(FitnessContext context)
    {
        _context = context;

    }



    public async Task GenerateSessionPlan()
    {

    }


}
