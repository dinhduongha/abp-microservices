using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrActWindowView
{
    public Guid Id { get; set; }

    public long? Sequence { get; set; }

    public Guid? ViewId { get; set; }

    public Guid? ActWindowId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? ViewMode { get; set; }

    public bool? Multi { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual IrActWindow? ActWindow { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrUiView? View { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
