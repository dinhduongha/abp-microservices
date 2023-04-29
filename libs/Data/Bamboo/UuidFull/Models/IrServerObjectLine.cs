using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class IrServerObjectLine
{
    public Guid Id { get; set; }

    public Guid? ServerId { get; set; }

    public Guid? Col1 { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? EvaluationType { get; set; }

    public string? Value { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual IrModelField? Col1Navigation { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrActServer? Server { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
