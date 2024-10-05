namespace Domain.Models;

public class AthleteInjuries: BaseEntity<long, Disease>
{
    public string Name { get; set; }
    public string Description { get; set; } = default!;
    public string InjuredImgUrl { get; private set; } = default!;

    public required Guid AthleteId { get; set; }
    //public Athlete Athlete { get; set; }

}
