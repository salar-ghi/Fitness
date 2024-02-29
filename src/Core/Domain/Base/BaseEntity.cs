namespace Domain;

public abstract class BaseEntity<TKey>
{
    public TKey Id { get; protected set; } = default!;
    public bool IsDeleted { get; protected set; } = false;
    public DateTime Created { get; protected set; } = default(DateTime);
    public Guid CreatedBy { get; protected set; } = default!;
    public DateTime Modified { get; protected set; } = default(DateTime);
    public Guid ModifiedBy { get; protected set; } = default!;
}
