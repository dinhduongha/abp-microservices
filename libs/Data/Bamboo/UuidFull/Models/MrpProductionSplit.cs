using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MrpProductionSplit
{
    public Guid Id { get; set; }

    public Guid? ProductionSplitMultiId { get; set; }

    public Guid? ProductionId { get; set; }

    public long? Counter { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MrpProductionSplitLine> MrpProductionSplitLines { get; } = new List<MrpProductionSplitLine>();

    public virtual MrpProduction? Production { get; set; }

    public virtual MrpProductionSplitMulti? ProductionSplitMulti { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
