using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class IrModelFieldsSelection
{
    public Guid Id { get; set; }

    public Guid? FieldId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Value { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModelField? Field { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
