using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrExport
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Resource { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<IrExportsLine> IrExportsLines { get; } = new List<IrExportsLine>();

    public virtual ResUser? WriteU { get; set; }
}
