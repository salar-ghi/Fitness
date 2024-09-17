using Domain.Base;

namespace Domain;

public abstract class BaseEntity<TId, TEntity>
    where TId: IEquatable<TId>
    where TEntity: BaseEntity<TId, TEntity>
{
    public TId Id { get; set; } = default!;
    public bool IsDeleted { get; set; } = false;
    public DateTime Created { get; set; } = default(DateTime);
    public Guid CreatedBy { get; set; } = default!;
    public DateTime Modified { get; set; } = default(DateTime);
    public Guid ModifiedBy { get; set; } = default!;
}
