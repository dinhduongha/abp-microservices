using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ChangeProductionQty
{
    public Guid Id { get; set; }

    public Guid? MoId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public decimal? ProductQty { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpProduction? Mo { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
