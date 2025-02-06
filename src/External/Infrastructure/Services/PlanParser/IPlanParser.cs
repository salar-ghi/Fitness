namespace Infrastructure.Services.PlanParser;

public interface IPlanParser
{
    WarmUpCoolDown ExtractWarmUpCoolDownRoutine(string content);
    WarmUpCoolDownModel ExtractWarmUpCoolDown(string content);
    List<WeekSchedule> ExtractWeeklySchedules(string content);
    List<WeekSchedule> ExtractWeeklySchedulesAlternative(string content);
}



// ********************************** //
public class FitnessPlanResponse
{
    public WarmUpCoolDownModel PrePostWorkout { get; set; }
    public WarmUpCoolDown PrePostWorkoutRoutine { get; set; }
    public List<WeekSchedule> WeeklySchedules { get; set; } = new();
    public List<WeekSchedule> WeeklySchedulesRoutine { get; set; } = new();
}

public class WarmUpCoolDownModel
{
    public List<string> WarmUp { get; set; } = new();
    public List<string> CoolDown { get; set; } = new();
}
public class WarmUpCoolDown
{
    public List<string> WarmUp { get; set; } = new();
    public List<string> CoolDown { get; set; } = new();
}

public class WeekSchedule
{
    public string WeekTitle { get; set; } = string.Empty;
    public int WeekNumber { get; set; }
    public List<DaySchedule> Days { get; set; } = new();
}

public class DaySchedule
{
    public string DayName { get; set; }
    public string FocusArea { get; set; }
    public List<ExerciseDetail> Exercises { get; set; } = new();
}

public class ExerciseDetail
{
    public string Name { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public int RestBetweenSetsSeconds { get; set; }
    public string Equipment { get; set; }
    public string ExerciseType { get; set; } = string.Empty;

}

public class ExerciseRoutine
{
    public string WarmUp { get; set; }
    //public string Stretching { get; set; }
    public string CoolDown { get; set; }
}