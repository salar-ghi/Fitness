using Domain.Base;

namespace Domain;

public abstract class BaseEntity : IBaseEntity
{
    public abstract Tkey Id<Tkey>(); //{ get; set; } 
    //public TKey Id { get; protected set; } = default!;
    public bool IsDeleted { get; set; } = false;
    public DateTime Created { get; set; } = default(DateTime);
    public Guid CreatedBy { get; set; } = default!;
    public DateTime Modified { get; set; } = default(DateTime);
    public Guid ModifiedBy { get; set; } = default!;
}
