using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MrpProductionSplitLine
{
    public Guid Id { get; set; }

    public Guid? MrpProductionSplitId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public decimal? Quantity { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpProductionSplit? MrpProductionSplit { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
