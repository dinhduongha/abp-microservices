using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrServerObjectLine
{
    public Guid Id { get; set; }

    public Guid? ServerId { get; set; }

    public Guid? Col1 { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? EvaluationType { get; set; }

    public string? Value { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual IrModelField? Col1Navigation { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrActServer? Server { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
