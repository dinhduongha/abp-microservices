using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrModelFieldsSelection
{
    public Guid Id { get; set; }

    public Guid? FieldId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Value { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModelField? Field { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
