namespace Domain.Models;

public class Athlete : BaseEntity<Guid, Athlete>
{
    //public User User { get; set; } = null!;
    public required Guid UserId { get; set; }

    public float Height { get; set; }
    public float Weight { get; set; }

    public string? AvatarUrl { get; private set; }
    public Sex Gender { get; set; } = default(Sex);
    public Age AgeRange { get; set; } = default(Age);
    public BodyType BodyType { get; set; } = default(BodyType);
    public Enums.Level Level { get; set; } = default(Enums.Level);
    public DateOnly DateOfBirth { get; set; }

    //public ICollection<AthleteInjuries> Injuries { get; } = new List<AthleteInjuries>();
    //public ICollection<AthleteImgs> Imgs { get; set; } = new List<AthleteImgs>();
    //public ICollection<Disease> Diseases { get; set; } = new List<Disease>();
}
