namespace Domain.Models;

public class AthleteInjuries: BaseEntity<long, Disease>
{
    public required string Name { get; set; }
    public string Description { get; private set; } = default!;
    public string InjuredImgUrl { get; private set; } = default!;

    public required Guid AthleteId { get; set; }
    //public Athlete Athlete { get; set; }

}
