using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class BaseModuleUpdate
{
    public Guid Id { get; set; }

    public long? Updated { get; set; }

    public long? Added { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? State { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
