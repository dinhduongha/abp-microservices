using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ThemeIrAttachment
{
    public long Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Key { get; set; }

    public string? Url { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<IrAttachment> IrAttachments { get; } = new List<IrAttachment>();

    public virtual ResUser? WriteU { get; set; }
}
