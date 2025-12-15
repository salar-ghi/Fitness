namespace Domain.Models;

public class Workout : BaseEntity<int, Workout>
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = default!;
    public string ImgUrl { get; set; } = default!;
    public int SportId { get; set; }
    public ICollection<Sport> Sport { get; set; } = new List<Sport>();
    public ICollection<WorkoutInstruction> WorkoutInstructions = new List<WorkoutInstruction>();
    public ICollection<WorkoutEquipment> WorkoutEquipment { get; set; } = new List<WorkoutEquipment>();
    public ICollection<WorkoutAgeRange> AgeRanges { get; set; } = new List<WorkoutAgeRange>();
    public IList<WorkoutLevel> Level { get; set; } = new List<WorkoutLevel>();
    public IList<BodyWorkout> BodyWorkouts = new List<BodyWorkout>();
    public ICollection<WorkoutSex> Sex { get; set; } = new List<WorkoutSex>();
}
