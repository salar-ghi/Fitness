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
            PlanDuration = Period.Daily,
            Level = Difficulty.Beginner,
            AverageEnergyLevel = AverageEnergyLevel.VariesThroughoutTheDay,
            SleepDuration = SleepDuration.SevenToEightHours,
            Name = "Test User",
            PhoneNumber = "+15555550123",
        };

        dto.ApplyAgeFromDateOfBirth(DateOnly.FromDateTime(DateTime.UtcNow));

        return dto;
    }
}
