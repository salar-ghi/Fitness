namespace Domain.Models;

public class Sport : BaseEntity<int>
{
    public required string Name { get; set; } = null!;
    public string ImgUrl { get; set; } = default!;
    public string Description { get; set; } = default!;
}
