using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrModelDatum
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public Guid? ResId { get; set; }

    public bool? Noupdate { get; set; }

    public string? Name { get; set; }

    public string? Module { get; set; }

    public string? Model { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
