using Application.DTOs.Response;
using Domain.Models;

namespace Application.Interfaces;

public interface IPlanManagingService
{

    Task PlanAiGeneratingMangement(RegisterDto dto);

    Task<List<PlanWorkoutResponseDto>> TestPlanProcessingTask(PlanDto dto);
}
