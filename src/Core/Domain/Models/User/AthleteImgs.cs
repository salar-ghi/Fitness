using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class AthleteImgs : BaseEntity<long, AthleteImgs>
{
    public string ImgUrl { get; set; } = default!;
    public string? Description { get; set; }

    public required Guid AthleteId { get; set; }

    //[ForeignKey(nameof(AthleteId))]
    //public virtual Athlete Athlete { get; set; }

}
