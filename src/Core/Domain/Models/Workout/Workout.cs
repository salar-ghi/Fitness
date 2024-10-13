namespace Domain.Models;

public class Workout : BaseEntity<int, Workout>
{
    public string Name { get; set; } = null!;
    public string Instruction { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string? ImgUrl { get; set; } 
    public string? VideoUrl { get; set; }

    public required int SportId { get; set; }
    //public ICollection<Sport> Sport { get; set; } = new List<Sport>();

    public ICollection<WorkoutAgeRange> AgeRanges { get; set; } = new List<WorkoutAgeRange>();

    public ICollection<WorkoutLevel> Level { get; set; } = new List<WorkoutLevel>();
    public ICollection<WorkoutEquipment> Equipment { get; set; } = new List<WorkoutEquipment>();
    public ICollection<WorkoutSex> Sex { get; set; } = new List<WorkoutSex>();
    // sex

}
