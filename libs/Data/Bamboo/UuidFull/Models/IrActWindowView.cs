using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class IrActWindowView
{
    public Guid Id { get; set; }

    public long? Sequence { get; set; }

    public Guid? ViewId { get; set; }

    public Guid? ActWindowId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? ViewMode { get; set; }

    public bool? Multi { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual IrActWindow? ActWindow { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrUiView? View { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
