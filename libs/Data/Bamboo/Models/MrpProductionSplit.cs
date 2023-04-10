using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MrpProductionSplit
{
    public Guid Id { get; set; }

    public Guid? ProductionSplitMultiId { get; set; }

    public Guid? ProductionId { get; set; }

    public long? Counter { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<MrpProductionSplitLine> MrpProductionSplitLines { get; } = new List<MrpProductionSplitLine>();

    public virtual MrpProduction? Production { get; set; }

    public virtual MrpProductionSplitMulti? ProductionSplitMulti { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
