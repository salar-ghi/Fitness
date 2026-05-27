using Domain.Enums;

namespace Infrastructure.Services.PlanService.Beginner;

public class DailyPlanService : IBeginnerPlanService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly FitnessContext _context;
    public DailyPlanService(IUnitOfWork unitOfWork, FitnessContext context)
    {
        _unitOfWork = unitOfWork;
        _context = context;
    }


    /// <summary>
    /// daily plan for beginner just is one specific part
    /// it requires warm up and cool down and almost 5 items
    /// which each item has almost 3 sets and each set has 10 reps
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>       
    public virtual async Task<List<Workout>> GenerateDailyPlanWorkouts(PlanDto dto, Difficulty level)
    {
        var selectedMuscles = dto.MusclePriorities?
            .Select(x => x.GroupName)
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList() ?? new List<string>();

        var selectedEquipment = dto.Equipments?
            .Select(x => x.Name)
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList() ?? new List<string>();

        var levelsToInclude = GetProgressionLevels(level);
        var exerciseCount = GetDailyExerciseCount(level);

        var query = _context.Workouts
            .Where(w => w.Level.Any(l => levelsToInclude.Contains(l.Level)));

        if (selectedMuscles.Count > 0)
        {
            query = query.Where(w => w.BodyWorkouts.Any(b => selectedMuscles.Contains(b.Body.Name)));
        }

        if (selectedEquipment.Count > 0)
        {
            query = query.Where(w =>
                w.WorkoutEquipment.Any(we => selectedEquipment.Contains(we.Equipment.Name)) ||
                w.WorkoutEquipment.Any(we => we.Equipment.Name == "Bodyweight"));
        }

        var workouts = await query
            .OrderBy(w => w.Name)
            .Take(exerciseCount)
            .ToListAsync();

        return workouts;
    }

    private static int GetDailyExerciseCount(Difficulty level) => level switch
    {
        Difficulty.Novice => 4,
        Difficulty.Beginner => 5,
        Difficulty.Intermediate => 6,
        Difficulty.Advanced => 7,
        Difficulty.Expert => 8,
        _ => 5,
    };

    private static List<Difficulty> GetProgressionLevels(Difficulty level) => level switch
    {
        Difficulty.Novice => new List<Difficulty> { Difficulty.Novice, Difficulty.Beginner },
        Difficulty.Beginner => new List<Difficulty> { Difficulty.Novice, Difficulty.Beginner, Difficulty.Intermediate },
        Difficulty.Intermediate => new List<Difficulty> { Difficulty.Beginner, Difficulty.Intermediate, Difficulty.Advanced },
        Difficulty.Advanced => new List<Difficulty> { Difficulty.Intermediate, Difficulty.Advanced, Difficulty.Expert },
        Difficulty.Expert => new List<Difficulty> { Difficulty.Advanced, Difficulty.Expert },
        _ => new List<Difficulty> { Difficulty.Beginner },
    };



}
