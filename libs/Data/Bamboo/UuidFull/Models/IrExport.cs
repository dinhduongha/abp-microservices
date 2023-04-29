using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class IrExport
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Resource { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<IrExportsLine> IrExportsLines { get; } = new List<IrExportsLine>();

    public virtual ResUser? WriteU { get; set; }
}
