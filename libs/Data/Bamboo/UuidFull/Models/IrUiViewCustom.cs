using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class IrUiViewCustom
{
    public Guid Id { get; set; }

    public Guid? RefId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Arch { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrUiView? Ref { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
