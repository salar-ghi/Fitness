namespace Domain.Models;

public class Disease : BaseEntity<long>
{
    public required string Name { get; set; }
    public string Description { get; private set; } = default!;

    public required Guid AthleteId { get; set; }
    //public Athlete Athlete { get; set; }

}
