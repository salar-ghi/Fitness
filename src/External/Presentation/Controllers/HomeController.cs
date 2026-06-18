namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
 
    private readonly IPlanManagingService _planManagingService;
    public HomeController(
        IPlanManagingService planManagingService)
    {
        _planManagingService = planManagingService;        
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var dto = CreateFakePlanDto();
        var plan = await _planManagingService.TestPlanProcessingTask(dto);
        return Ok(plan);
    }

    private static PlanDto CreateFakePlanDto()
    {
        var dto = new PlanDto
        {
            Height = 170,
            Weight = 90,
            Gender = Sex.Male,
            DateOfBirth = new DateOnly(1994, 5, 15),
            BodyShapeType = BodyShapeType.Heavy,
            BodyType = BodyType.Endomorph,
            Goal = FitnessGoal.LoseWeight,
            DesiredBodyType = DesiredBodyType.Muscular,
            PlanDuration = Period.Monthly,
            Level = Difficulty.Beginner,
            Place = Place.Home,
            WorkoutDurationPreference = WorkoutDurationPreference.ThirtyToFortyFiveMinutes,
            AverageEnergyLevel = AverageEnergyLevel.VariesThroughoutTheDay,
            SleepDuration = SleepDuration.SevenToEightHours,
            Name = "Test User",
            PhoneNumber = "+989108592503",
        };

        dto.PlanDays.AddRange(new[]
        {
            new PlanDaysDto { Day = DayOfWeek.Monday, Hour = new TimeSpan(18, 0, 0) },
            new PlanDaysDto { Day = DayOfWeek.Wednesday, Hour = new TimeSpan(18, 0, 0) },
            new PlanDaysDto { Day = DayOfWeek.Friday, Hour = new TimeSpan(18, 0, 0) },
        });

        dto.MusclePriorities.AddRange(new[]
        {
            new MusclePriorityDto((int)MuscleGroup.Chest, MuscleGroup.Chest.ToString()),
            new MusclePriorityDto((int)MuscleGroup.Back, MuscleGroup.Back.ToString()),
            new MusclePriorityDto((int)MuscleGroup.Shoulders, MuscleGroup.Shoulders.ToString()),
        });

        dto.ApplyAgeFromDateOfBirth(DateOnly.FromDateTime(DateTime.UtcNow));

        return dto;
    }
}
