namespace Domain.Base;

public interface IBaseEntity
{
    bool IsDeleted { get; set; }
    DateTime Created { get; set; }
    Guid CreatedBy { get; set; }
    DateTime Modified { get; set; }
    Guid ModifiedBy { get; set; }
}
