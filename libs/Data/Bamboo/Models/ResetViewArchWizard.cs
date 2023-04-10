using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ResetViewArchWizard
{
    public Guid Id { get; set; }

    public Guid? ViewId { get; set; }

    public Guid? CompareViewId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? ResetMode { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual IrUiView? CompareView { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrUiView? View { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
