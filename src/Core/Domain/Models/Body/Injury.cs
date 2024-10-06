namespace Domain.Models;

public class Injury : BaseEntity<int, Injury>
{
    public string Name { get; set; }
    public string Description { get; set; } = default!;
    public string InjuredImgUrl { get; set; } = default!;
    public int? BodyId { get; set; }
}