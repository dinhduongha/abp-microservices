using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrUiViewCustom
{
    public Guid Id { get; set; }

    public Guid? RefId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Arch { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrUiView? Ref { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
