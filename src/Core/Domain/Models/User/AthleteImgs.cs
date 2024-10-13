namespace Domain.Models;

public class AthleteImgs : BaseEntity<long, AthleteImgs>
{
    public string ImgUrl { get; set; } = default!;
    public string? Description { get; set; }

    public required Guid AthleteId { get; set; }
    //public Athlete Athlete { get; set; }

}
