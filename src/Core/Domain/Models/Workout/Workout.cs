namespace Domain.Models;

public class Workout : BaseEntity<int, Workout>
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = default!;
    public string ImgUrl { get; set; } = default!; // workout banner

    //public string Instruction { get; set; } = default!; // move to another table to tech more carefully each step seperately.
    //public string? ImgUrl { get; set; } 
    //public string? VideoUrl { get; set; }

    //public ICollection<WorkoutInstruction> WorkoutInstructions = new List<WorkoutInstruction>();
    //public ICollection<BodyWorkout> BodyWorkouts = new List<BodyWorkout>();


    public required int SportId { get; set; }
    //public ICollection<Sport> Sport { get; set; } = new List<Sport>();



    public ICollection<WorkoutAgeRange> AgeRanges { get; set; } = new List<WorkoutAgeRange>();

    public ICollection<WorkoutEquipment> Equipment { get; set; } = new List<WorkoutEquipment>();
    public ICollection<WorkoutLevel> Level { get; set; } = new List<WorkoutLevel>();
    public ICollection<WorkoutSex> Sex { get; set; } = new List<WorkoutSex>();
    // sex

}
