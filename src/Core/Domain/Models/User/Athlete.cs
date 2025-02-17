using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class Athlete : BaseEntity<Guid, Athlete>
{

    public float Height { get; set; }
    public float Weight { get; set; }

    public string? AvatarUrl { get; private set; }
    public Sex Gender { get; set; } = default(Sex);
    public Age AgeRange { get; set; } = default(Age);
    public BodyType BodyType { get; set; } = default(BodyType);
    public Difficulty Level { get; set; } = default(Difficulty);
    public DateOnly DateOfBirth { get; set; }
    
    public required Guid UserId { get; set; }

    //[ForeignKey(nameof(UserId))]
    //public virtual User User { get; set; } = null!;

    //public virtual ICollection<AthleteImgs> Imgs { get; set; } = new List<AthleteImgs>();
    //public virtual ICollection<AthleteInjuries> Injuries { get; } = new List<AthleteInjuries>();
    //public virtual ICollection<Disease> Diseases { get; set; } = new List<Disease>();
}
