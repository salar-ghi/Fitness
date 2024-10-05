using Domain.Base;
using Microsoft.AspNetCore.Identity;

namespace Domain.Models;

public class User : IdentityUser<Guid>, IBaseEntity
{
    //public Guid Id { get; set; }
    public string FName { get; set; } = default!;
    public string LName { get; set; } = default!;
    //public string Email { get; private set; } = default!;
    //public required string CellPhone { get; set; } = null!;
    public string ImgUrl { get; private set; } = default!;
    //public string UserName { get; private set; } = default!;
    public string Password { get; private set; } = default!;

    public bool IsDeleted { get; set; }
    public DateTime Created { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime Modified { get; set; }
    public Guid ModifiedBy { get; set; }


    //public Athlete? Athlete { get; private set; }
}
