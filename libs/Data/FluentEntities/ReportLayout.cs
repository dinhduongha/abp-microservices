using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ReportLayout
{
    public long Id { get; set; }

    public Guid? ViewId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Image { get; set; }

    public string? Pdf { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<BaseDocumentLayout> BaseDocumentLayouts { get; } = new List<BaseDocumentLayout>();

    public virtual ResUser? CreateU { get; set; }

    public virtual IrUiView? View { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
