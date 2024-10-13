namespace Domain.Models;

public class AthleteInjuries: BaseEntity<long, AthleteInjuries>
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string InjuredImgUrl { get; set; } = default!;
    public int? BodyId { get; set; }

    public required Guid AthleteId { get; set; }
    //public Athlete Athlete { get; set; }

}
