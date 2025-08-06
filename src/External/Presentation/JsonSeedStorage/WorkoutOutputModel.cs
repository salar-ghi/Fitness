namespace Presentation.JsonSeedStorage;

public class WorkoutOutputModel
{

}

// Output Models
public class MuscleTarget
{
    public string MuscleTargetLevel { get; set; }
}

public class WorkoutOutput
{
    public string WorkoutName { get; set; }
    public Dictionary<string, string> Instruction { get; set; } = new Dictionary<string, string>
    {
        { "1", "" },
        { "2", "" },
        { "3", "" }
    };
    public string Equipment { get; set; }
    public string WorkoutLevel { get; set; }
    public Dictionary<string, MuscleTarget> Muscles { get; set; } = new Dictionary<string, MuscleTarget>();
}