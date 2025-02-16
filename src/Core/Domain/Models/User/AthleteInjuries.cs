using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class AthleteInjuries: BaseEntity<long, AthleteInjuries>
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string InjuredImgUrl { get; set; } = default!;
    public int? BodyId { get; set; }

    public required Guid AthleteId { get; set; }
    //[ForeignKey(nameof(AthleteId))]
    //public virtual Athlete Athlete { get; set; }
}
