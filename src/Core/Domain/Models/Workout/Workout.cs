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

    // public ICollection<Level>  Level { get; set; } = new List<Level>();
    // public ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();
    // public ICollection<AgeRange> AgeRanges { get; set; } = new List<AgeRange>();
    // sex

}
