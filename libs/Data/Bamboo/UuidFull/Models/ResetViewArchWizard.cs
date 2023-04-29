using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ResetViewArchWizard
{
    public Guid Id { get; set; }

    public Guid? ViewId { get; set; }

    public Guid? CompareViewId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? ResetMode { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual IrUiView? CompareView { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrUiView? View { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
