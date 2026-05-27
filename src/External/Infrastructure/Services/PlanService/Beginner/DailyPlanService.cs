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
    public virtual async Task<List<Workout>> GenerateDailyPlanWorkouts(PlanDto dto)
    {
        const int exercisePerSessionDailyDurationBeginnerLevel = 5;
        var muscleSelectedNum = dto.MusclePriorities.Count;

        // depend on place and equipment right now
        // imagine who workout at home, so less eqipment who has.
        var space = dto.Place;

        // most warm up exercises should be according
        // to main exercises that warm up those muscles
        // that want to exercise.

        var muscleGroupName = dto.MusclePriorities.Select(z => z.GroupName).ToList();
        var muscleProperties = await _context.Bodies
            .Where(z => muscleGroupName.Contains(z.Name))
            .ToListAsync();

        //var muscles = _context.Bodies
        //    .Where(s => dto.MusclePriorities.Contains(s.Name)).ToList();

        //var warmupActivities = _context.Workouts
        //    .Where(z => z.Sport.Any(s => s.Name == "Cardio"))
        //    .Where(w => w.Level.Any(z =>
        //                    z.Level == Difficulty.Novice ||
        //                    z.Level == Difficulty.Beginner ||
        //                    z.Level == Difficulty.Intermediate))
        //    .Where(y => y.WorkoutEquipment.Any(s =>
        //                    s.Equipment.Name == "Cardio" ||
        //                    s.Equipment.Name == "Bodyweight" ||
        //                    s.Equipment.Name == "stretches" ||
        //                    dto.Equipments.Any(z => z.Name == "Bands") ? s.Equipment.Name == "Bands" : s.Equipment.Name == "Bands"))
        //    .Where(s => s.BodyWorkouts.Any(z => muscles.Any(x => x.Name == s.Name)))
        //    .ToList();
            //.Include(z => z.Sport.Where(x => x.Name == "Cardio"))
            // ?? body workout

        var exercseActivities = " ";
        var cooldownActivities = " ";

        var warmupActivities = await _context.Workouts
            .Where(z => z.Sport.Any(s => s.Name == "Cardio") &&
                z.Level.Any(l => l.Level == Difficulty.Novice ||
                                 l.Level == Difficulty.Beginner ||
                                 l.Level == Difficulty.Intermediate) &&
                z.WorkoutEquipment.Any(e =>
                    e.Equipment.Name == "Cardio" ||
                    e.Equipment.Name == "Bodyweight" ||
                    e.Equipment.Name == "stretches" 
                    //dto.Equipments.Any(eq => eq.Name == e.Equipment.Name)
                    ) &&
                //z.BodyWorkouts.Any(b => dto.MusclePriorities.Any(mp => mp.GroupName == b.Body.Name)))
                z.BodyWorkouts.Any(b => muscleProperties.Any(z => z.Name == b.Body.Name)))
            //.Take(5)
            .ToListAsync();

        return warmupActivities;
    }



}
