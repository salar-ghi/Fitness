namespace Domain.Models;

public class Athlete : BaseEntity<Guid>
{
    //public User User { get; set; } = null!;
    public required Guid UserId { get; set; }

    public string? AvatarUrl { get; private set; }
    public Sex Gender { get; private set; } = default(Sex);
    public Age Age { get; private set; } = default(Age);
    public BodyType BodyType { get; private set; } = default(BodyType);
    public Enums.Level Level { get; private set; } = default(Enums.Level);
    public DateOnly DateOfBirth { get; set; }

    //public ICollection<AthleteInjuries> Injuries { get; } = new List<AthleteInjuries>();
    //public ICollection<AthleteImgs> Imgs { get; set; } = new List<AthleteImgs>();
    //public ICollection<Disease> Diseases { get; set; } = new List<Disease>();
}
