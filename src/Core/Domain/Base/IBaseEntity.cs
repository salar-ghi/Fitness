﻿namespace Domain.Base;

public interface IBaseEntity
{
    //public TKey Id { get; protected set; }
    bool IsDeleted { get; set; }
    DateTime Created { get; set; }
    Guid CreatedBy { get; set; }
    DateTime Modified { get; set; }
    Guid ModifiedBy { get; set; }
}