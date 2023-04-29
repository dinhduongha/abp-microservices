using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MrpImmediateProductionLine
{
    public Guid Id { get; set; }

    public Guid? ImmediateProductionId { get; set; }

    public Guid? ProductionId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public bool? ToImmediate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpImmediateProduction? ImmediateProduction { get; set; }

    public virtual MrpProduction? Production { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
