namespace Domain.Models;

public class Workout : BaseEntity<int, Workout>
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = default!;
    public string ImgUrl { get; set; } = default!;
    public int SportId { get; set; }
    public ICollection<Sport> Sport { get; set; } = new List<Sport>();
    public ICollection<WorkoutInstruction> WorkoutInstructions { get; set; } = new List<WorkoutInstruction>();
    public ICollection<WorkoutEquipment> WorkoutEquipment { get; set; } = new List<WorkoutEquipment>();
    public ICollection<WorkoutAgeRange> AgeRanges { get; set; } = new List<WorkoutAgeRange>();
    public ICollection<WorkoutLevel> Level { get; set; } = new List<WorkoutLevel>();
    public ICollection<BodyWorkout> BodyWorkouts { get; set; } = new List<BodyWorkout>();
    public ICollection<WorkoutSex> Sex { get; set; } = new List<WorkoutSex>();
}
