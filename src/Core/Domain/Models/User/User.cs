namespace Domain.Models;

public class User : IdentityUser<Guid>, IBaseEntity
{
    public string FName { get; set; } = default!;
    public string LName { get; set; } = default!;
    public string ImgUrl { get; private set; } = default!;

    public bool IsDeleted { get; set; }
    public DateTime Created { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime Modified { get; set; }
    public Guid ModifiedBy { get; set; }


    //public virtual Athlete? Athlete { get; private set; }
}
