using Domain.Models;

namespace Application.Interfaces;

public interface IPlanManagingService
{

    Task PlanAiGeneratingMangement(RegisterDto dto);

    Task<List<Workout>> TestPlanProcessingTask();
}
