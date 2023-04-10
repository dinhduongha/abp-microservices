using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class WebsiteSaleExtraField
{
    public Guid Id { get; set; }

    public Guid? WebsiteId { get; set; }

    public long Sequence { get; set; }

    public Guid? FieldId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModelField? Field { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
