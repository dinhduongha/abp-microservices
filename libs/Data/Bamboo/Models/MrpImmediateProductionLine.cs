using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MrpImmediateProductionLine
{
    public Guid Id { get; set; }

    public Guid? ImmediateProductionId { get; set; }

    public Guid? ProductionId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? ToImmediate { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpImmediateProduction? ImmediateProduction { get; set; }

    public virtual MrpProduction? Production { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
