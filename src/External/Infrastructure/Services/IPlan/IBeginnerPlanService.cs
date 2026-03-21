namespace Infrastructure.Services;

public interface IBeginnerPlanService
{
    Task<List<Workout>> GenerateDailyPlanWorkouts(PlanDto dto);
}
