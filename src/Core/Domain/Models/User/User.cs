namespace Domain.Models;

public class User : BaseEntity<Guid>
{
    public required string Name { get; set; } = default!;
    public string Email { get; private set; } = default!;
    public required string CellPhone { get; set; } = null!;
    public string ImgUrl { get; private set; } = default!;
    public string UserName { get; private set; } = default!;
    public string Password { get; private set; } = default!;

    //public Athlete? Athlete { get; private set; }
}
