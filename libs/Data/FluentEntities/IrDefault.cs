using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrDefault
{
    public Guid Id { get; set; }

    public Guid? FieldId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Condition { get; set; }

    public string? JsonValue { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModelField? Field { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
